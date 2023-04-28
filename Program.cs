using System;

public class Recipe 
{
    static void Main() 
    {
        string Recipe = "Sanele's Recipe Instructions";
        Console.WriteLine(Recipe);
        Console.WriteLine("Enter the number of ingredients:");
        string ingredients = Console.ReadLine();
        Console.WriteLine("Ingredients = " + ingredients);//Reads what number has been entered for the ingredients.

         
        Console.WriteLine("Please enter the ingredient name, Quanity and unit of measurement and seperate with a comma: Example-1 teaspoon of sugar,");
        string input = Console.ReadLine();

        string[] measurements = input.Split(','); //Function used to seperate/organise users input on ingredients. 

        Console.WriteLine("Ingredients and measurements");
        foreach (string value in measurements) //Used to created a format that is easier to read and ordered. 
        {
            Console.WriteLine(value.Trim());// function is used to remove any unnecessary spacing in the user's input. 
  
        }

    }
}





