using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class HideCatedral : MonoBehaviour 
{

	public static string idioma="Spanish";
	public static string idioma2="English";
	public static string idioma3="German";  
	public static string text;
	public  string option;
	public  string option2;
	public  string option3;
	public static bool status= true;





	public static string GetLenguage(){
		text= Application.systemLanguage.ToString();
		return text;

	}

	public void espanol(){
		epoca ();

			switch(option){
			case "Catedral":
				if (GameObject.Find ("Spanish").renderer.enabled == true) {
					GameObject.Find ("Spanish").renderer.enabled = false;
					GameObject.Find ("Spanish2").renderer.enabled = false;
					GameObject.Find ("Spanish3").renderer.enabled = false;
					
					
					
					
					
				} else {
					GameObject.Find ("Spanish").renderer.enabled = true;
					GameObject.Find ("Spanish2").renderer.enabled = false;
					GameObject.Find ("Spanish3").renderer.enabled = false;
					
					
				}
				option= null;
				break;
				
			case "Palacio":
				if (GameObject.Find ("Spanish2").renderer.enabled == true) {
					GameObject.Find ("Spanish").renderer.enabled = false;
					GameObject.Find ("Spanish3").renderer.enabled = false;
					GameObject.Find ("Spanish2").renderer.enabled = false;
					
					
				} else {
					GameObject.Find ("Spanish").renderer.enabled = false;
				    GameObject.Find ("Spanish2").renderer.enabled = true;
					GameObject.Find ("Spanish3").renderer.enabled = false;
					
					
				}
				option= null;
				break;
			case "Default":
				option = null;
				break;
				
			}
		}
		

public void english(){
		age ();
			switch(option2){
		case "CatedralAge":
			if (GameObject.Find ("English").renderer.enabled == true) {
				GameObject.Find ("English").renderer.enabled = false;
				GameObject.Find ("English2").renderer.enabled = false;
				GameObject.Find ("English3").renderer.enabled = false;
			} else {
				GameObject.Find ("English").renderer.enabled = true;
				GameObject.Find ("English2").renderer.enabled = false;
				GameObject.Find ("English3").renderer.enabled = false;
			}break;
			

		case "PalacioAge":
			if (GameObject.Find ("English2").renderer.enabled == true) {
				GameObject.Find ("English").renderer.enabled = false;
				GameObject.Find ("English2").renderer.enabled = false;
				GameObject.Find ("English3").renderer.enabled = false;
			} else {
				GameObject.Find ("English").renderer.enabled = false;
				GameObject.Find ("English2").renderer.enabled = true;
				GameObject.Find ("English3").renderer.enabled = false;
			}
			break;

		case "Default":
			break;
		}
	
}

	public void aleman(){
		Zeit ();
				
						switch (option3) {
				
						case "CatedralZeit":
								if (GameObject.Find ("German").renderer.enabled == true) {
										GameObject.Find ("German").renderer.enabled = false;
										GameObject.Find ("German2").renderer.enabled = false;
										GameObject.Find ("German3").renderer.enabled = false;
								} else {
										GameObject.Find ("German").renderer.enabled = true;
										GameObject.Find ("German2").renderer.enabled = false;
										GameObject.Find ("German3").renderer.enabled = false;
								}
								break;
						
						case"PalacioZeit":
								if (GameObject.Find ("German2").renderer.enabled == true) {
										GameObject.Find ("German").renderer.enabled = false;
										GameObject.Find ("German2").renderer.enabled = false;
										GameObject.Find ("German3").renderer.enabled = false;
								} else {
										GameObject.Find ("German").renderer.enabled = false;
										GameObject.Find ("German2").renderer.enabled = true;
										GameObject.Find ("German3").renderer.enabled = false;
								}
								break;
						
						case "Default":
								break;
						}
				
		}


			                
				


	




	public string epoca(){
		if  ((GameObject.Find("tem1").renderer.enabled== true)||(GameObject.Find("tem2").renderer.enabled== true)
		     ||(GameObject.Find("tem3").renderer.enabled== true)||(GameObject.Find("tem4").renderer.enabled== true)){
			option = "Palacio";
			return option;
		}
		if ((GameObject.Find("templo").renderer.enabled== true)||(GameObject.Find("templo2").renderer.enabled== true)||(GameObject.Find("templo3").renderer.enabled== true)||(GameObject.Find("templo4").renderer.enabled== true)
		    ||(GameObject.Find("templo5").renderer.enabled== true)||(GameObject.Find("templo6").renderer.enabled== true)||(GameObject.Find("templo7").renderer.enabled== true)
		   ||(GameObject.Find("templo8").renderer.enabled== true)) {
		   option="Catedral";
			return option;
						
				}
		else {
			GameObject.Find("Spanish").renderer.enabled =false;
			GameObject.Find("English").renderer.enabled = false;
			GameObject.Find("German").renderer.enabled = false;
			
			GameObject.Find("Spanish2").renderer.enabled =false;
			GameObject.Find("English2").renderer.enabled = false;
			GameObject.Find("German2").renderer.enabled = false;
			
			GameObject.Find("Spanish3").renderer.enabled =false;
			GameObject.Find("English3").renderer.enabled = false;
			GameObject.Find("German3").renderer.enabled = false;

			option="Default";
			return option;
				}
						

	}

	public  string age (){

		if ((GameObject.Find("templo").renderer.enabled== true)||(GameObject.Find("templo2").renderer.enabled== true)||(GameObject.Find("templo3").renderer.enabled== true)||(GameObject.Find("templo4").renderer.enabled== true)
		    ||(GameObject.Find("templo5").renderer.enabled== true)||(GameObject.Find("templo6").renderer.enabled== true)||(GameObject.Find("templo7").renderer.enabled== true)
		    ||(GameObject.Find("templo8").renderer.enabled== true))
		{
			option2="CatedralAge";
			return option2;
						
				}
		if  ((GameObject.Find ("tem1").renderer.enabled == true) || (GameObject.Find ("tem2").renderer.enabled == true)
		     || (GameObject.Find ("tem3").renderer.enabled == true)|| (GameObject.Find ("tem4").renderer.enabled == true)){
						option2 = "PalacioAge";
			            return option2;
									} 

		else {
			GameObject.Find("Spanish").renderer.enabled =false;
			GameObject.Find("English").renderer.enabled = false;
			GameObject.Find("German").renderer.enabled = false;
			
			GameObject.Find("Spanish2").renderer.enabled =false;
			GameObject.Find("English2").renderer.enabled = false;
			GameObject.Find("German2").renderer.enabled = false;
			
			GameObject.Find("Spanish3").renderer.enabled =false;
			GameObject.Find("English3").renderer.enabled = false;
			GameObject.Find("German3").renderer.enabled = false;

			option2="Default";
			return option2;
				}

		
		}



	public  string Zeit(){
		if ((GameObject.Find("templo").renderer.enabled== true)||(GameObject.Find("templo2").renderer.enabled== true)||(GameObject.Find("templo3").renderer.enabled== true)||(GameObject.Find("templo4").renderer.enabled== true)
		    ||(GameObject.Find("templo5").renderer.enabled== true)||(GameObject.Find("templo6").renderer.enabled== true)||(GameObject.Find("templo7").renderer.enabled== true)
		    ||(GameObject.Find("templo8").renderer.enabled== true)) {
			option3="CatedralZeit";
			return option3;
						
				}
		if  ((GameObject.Find ("tem1").renderer.enabled == true) || (GameObject.Find ("tem2").renderer.enabled == true)
		     || (GameObject.Find ("tem3").renderer.enabled == true)|| (GameObject.Find ("tem4").renderer.enabled == true)){

						option3 = "PalacioZeit";
						return option3;
						
				} 
		else {
			GameObject.Find("Spanish").renderer.enabled =false;
			GameObject.Find("English").renderer.enabled = false;
			GameObject.Find("German").renderer.enabled = false;
			
			GameObject.Find("Spanish2").renderer.enabled =false;
			GameObject.Find("English2").renderer.enabled = false;
			GameObject.Find("German2").renderer.enabled = false;
			
			GameObject.Find("Spanish3").renderer.enabled =false;
			GameObject.Find("English3").renderer.enabled = false;
			GameObject.Find("German3").renderer.enabled = false;

			option3="Default";
			return option3;
				}

		

		}


	void Start(){
		
		
			
	}
	
	
	void OnMouseDown(){
		
		if (idioma.Equals (GetLenguage ())) {
			
			espanol();
		}	
		if (idioma2.Equals (GetLenguage ())) {
			
			english();
		}
		if (idioma3.Equals (GetLenguage ())) {
			
						aleman ();
			
		 } 

		
	}



}
