using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceScripts : MonoBehaviour{
    
    public static void roll2Dice(){
        rollNDice(2);
        return;
    }

    private static int[] rollNDice(int number_of_dice){
        int[] dice_array = new int[number_of_dice];

        for(int i = 0; i<number_of_dice; i++){
            dice_array[i] = UnityEngine.Random.Range(1, 7); 
        }
        Debug.Log(dice_array.ToString());
        return dice_array;
    }
}
