extends Node2D

@export var enemy_scenes: Array[PackedScene] = []


@onready var player_spawn_pos = $playerspawn
@onready var laser_container = $lasercontainer
@onready var timer = $EnemySpawnTimer
@onready var Enemy_Container = $EnemyContainer
@onready var hud = $UILayer/HUD
@onready var gos = $UILayer/GameOver
@onready var pb = $ParallaxBackground


var player = null
var score := 0:
	set(value):
		score = value
		hud.score = score
var highscore

var scroll_speed = 100

func _ready():
	var save_file = FileAccess.open("user://save.data", FileAccess.READ)
	if save_file!=null:
		highscore = save_file.get_32()
	else:
		highscore = 0
		save_game()
	
	score = 0
	player = get_tree().get_first_node_in_group("player")
	player.global_position = player_spawn_pos.global_position
	player.laser_shot.connect(_on_player_laser_shot)
	player.killed.connect(_on_player_killed)


func save_game():
	var save_file = FileAccess.open("user://save.data", FileAccess.WRITE)
	save_file.store_32(highscore)

func _process(delta):
	if Input.is_action_just_pressed("quit"):
		get_tree().quit()
	elif Input.is_action_just_pressed("reset"):
			get_tree().reload_current_scene()
	
	if timer.wait_time > 0.5:
		timer.wait_time -= delta*0.05
	elif timer.wait_time < 0.5:
		timer.wait_time = 0.5


	pb.scroll_offset.y += delta*scroll_speed
	if pb.scroll_offset.y >= 960:
		pb.scroll_offset.y = 0



func _on_player_laser_shot(laser_scene, location):
	var laser = laser_scene.instantiate()
	laser.global_position = location
	laser_container.add_child(laser)


func _on_enemy_spawn_timer_timeout():
	var e = enemy_scenes.pick_random().instantiate()
	e.global_position = Vector2(randf_range(50, 490), -50)
	e.killed.connect(_on_enemy_killed)
	Enemy_Container.add_child(e)
	
func _on_enemy_killed(scorepoints):
	score += scorepoints
	if score > highscore:
		highscore = score
	print(score)

func _on_player_killed():
	gos.set_score(score)
	gos.set_highscore(highscore)
	save_game()
	await get_tree().create_timer(1).timeout
	gos.visible = true
