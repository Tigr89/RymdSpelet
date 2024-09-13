extends CharacterBody2D


var scene = preload("res://laser_green.tscn")
var instance = scene.instantiate()

const SPEED = 300.0

func _physics_process(delta):



	var direction = Input.get_axis("left", "right")
	if direction:
		velocity.x = direction * SPEED
	else:
		velocity.x = move_toward(velocity.x, 0, SPEED)
	if Input.is_action_just_pressed("click"):
		get_parent().add_child(instance)
		instance.position = self.position + Vector2(0, -50)

	move_and_slide()
