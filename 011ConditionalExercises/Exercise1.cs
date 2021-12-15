namespace _011ConditionalExercises
{
    public class Exercise1
    {
        /*
         * Write a program and ask the user to enter a number. 
         * The number should be between 1 to 10. 
         * If the user enters a valid number, 
         * display "Valid" on the console. 
         * Otherwise, display "Invalid". 
         * (This logic is used a lot in applications 
         * where values entered into input boxes need to be validated.)
         */
        public static string isValid(string num)
        {
            string result = "Invalid";

            if (int.Parse(num) >= 1 && int.Parse(num) <= 10) {
                result = "Valid";
            }
            else
            {
                result = "Invalid";
            }
            return result;
        }
    }
}
