using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadShot : GunScript {



	public float spreadAngle1;
	public float spreadAngle2;

	public void Start(){
		
	}

	public override void Shoot(){ 

		if (Time.time > shotTimer){
			shotTimer = Time.time + fireInterval / 1000;
			FireProjectile(projStartPoint.position, projStartPoint.rotation);
			FireProjectile(projStartPoint.position, projStartPoint.rotation * Quaternion.Euler(0,45,0));
			FireProjectile(projStartPoint.position, projStartPoint.rotation * Quaternion.Euler(0,315,0));
		}
	}

	public void FireProjectile(Vector3 pos, Quaternion rot){
		ProjectileScript newProjectile = Instantiate(projectile, pos, rot) as ProjectileScript;
		newProjectile.SetSpeed (projStartVelocity);
	}
}
