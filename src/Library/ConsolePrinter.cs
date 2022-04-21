namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
       public ConsolePrinter(Recipe receta)
        {
            this.Receta = receta;
            System.Console.WriteLine($"Receta de {this.Receta.FinalProduct.Description}:");
            foreach (Step step in this.Receta.steps)
            {
                System.Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }

        }

        public Recipe Receta { get; set; }
    }
}