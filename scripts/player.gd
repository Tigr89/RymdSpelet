class_name Player extends CharacterBody2D

signal laser_shot(laser_scene, location)
signal killed

@export var speed = 350

@onready var barrel = $barrel

var laser_scene = preload("res://scenes/laser.tscn")

var shoot_cd := false 

func _process(delta):
	if Input.is_action_pressed("shoot"):
		if !shoot_cd:
			shoot_cd = true
			shoot()
			await get_tree().create_timer(0.25).timeout
			shoot_cd = false

func _physics_process(delta):
	var direction = Vector2(Input.get_axis("left", "right"), Input.get_axis("up", "down"))
	velocity = direction * speed
	move_and_slide()
	
	global_position = global_position.clamp(Vector2.ZERO, get_viewport_rect().size)

func shoot():
	laser_shot.emit(laser_scene, barrel.global_position)

func die():
	killed.emit()
	queue_free()
