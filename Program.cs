namespace BMICalculator
{
    public class Program
    {
        public static double GetNumInput(string prompt)
        {
            // Return Result 
            double num;

        askNumInput:
            Console.WriteLine($"Please enter a {prompt}");
            bool issuccess = Double.TryParse(Console.ReadLine(), out num);
            if (!issuccess)
            {
                Console.WriteLine($"{prompt} Cannot Be A Character or String!");
                goto askNumInput;
            }

            return num;
        }

        public static void Main(string[] args)
        {
            // Variable to Calculate
            double weight, height;

            height = GetNumInput("height");
            weight = GetNumInput("weight");


            // Caculate bmi
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            // Print Out Result
            Console.Write("BMI: " + bmi);
            if (bmi < 18.0)
            {
                Console.WriteLine(" Underweight");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine(" Normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine(" Normal");
            }
            else
            {
                Console.WriteLine(" Obese");
            }
        }
    }
}