﻿using System;

class Program{
    static void Main(){
        for (int a = 0; a < 10; a++)
        {
            try{
                int num = ReadNumber(1, 100);
                Console.WriteLine("Square root of the number is: " + Math.Sqrt(num));}
            
            catch (Exception x){
                Console.WriteLine(x.Message);}
            
            finally{
                Console.WriteLine("Good bye");}
        }
    }

    static int ReadNumber(int start, int end){
        int num;
        Console.Write($"Enter an integer between {start} and {end}: ");
        if (int.TryParse(Console.ReadLine(), out num)){
            if (num >= start && num <= end){
            return num;}
            
            else{
                throw new Exception ("Invalid number!");}
        }
        
        else{
            throw new FormatException("Invalid input! Please enter a valid integer.");}
    }
}