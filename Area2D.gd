extends Area2D

const SPEED = 300.0


func _physics_process(delta):
	global_position. y += -SPEED * delta
	
