using System;
using SampleClassification.Model;

namespace SampleClassification.Consume
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Waiting the text: ");
                var text = Console.ReadLine();

                // True is non-toxic, false is toxic
                var result = ConsumeModel.Predict(new ModelInput { Col0 = text });

                Console.WriteLine($"Text: {text} | Prediction: { FormatPrediction(result.Prediction)} sentiment | Score: {string.Join(" ", result.Score)}");

                Console.WriteLine("Try again? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
        }

        private static string FormatPrediction(string prediction) =>
            Convert.ToBoolean(Convert.ToInt16(prediction)) ? "Non Toxic" : "Toxic";     
    }
}
