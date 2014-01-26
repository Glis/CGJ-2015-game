#pragma strict

var gameSetup : GameSetup;

function OnCollisionEnter2D(collision : Collision2D){
	
	for (var contact : ContactPoint2D in collision.contacts) {
		if(contact.collider.tag.Equals('Player')){			
		
			var player1Rendered=gameSetup.player1.GetComponent(SpriteRenderer) as SpriteRenderer;
			if(player1Rendered.sprite.Equals(gameSetup.player1Sprite)){
				player1Rendered.sprite=gameSetup.player2Sprite;
			}else{			
				player1Rendered.sprite=gameSetup.player1Sprite;
			}

			var player2Rendered=gameSetup.player2.GetComponent(SpriteRenderer) as SpriteRenderer;																								
			if(player2Rendered.sprite.Equals(gameSetup.player2Sprite)){
				player2Rendered.sprite=gameSetup.player1Sprite;
			}else{			
				player2Rendered.sprite=gameSetup.player2Sprite;
			}
																											
			break;
		}	
	}	
}
