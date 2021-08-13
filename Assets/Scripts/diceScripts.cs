using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScripts : MonoBehaviour{
    
    public static void Roll2Dice(){
        RollNDF(2,6);
        return;
    }

    //roll N Number of dice with largest face value of F
    private static int[] RollNDF(int number_of_dice, int largest_face_value){
        int[] dice_array = new int[number_of_dice];

        for(int i = 0; i<number_of_dice; i++){
            dice_array[i] = UnityEngine.Random.Range(1, largest_face_value); 
        }
        Debug.Log(dice_array.ToString());
        return dice_array;
    }
}
