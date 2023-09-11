
using System;
using System.Collections;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

/* Al crear esta clase con el metodo PrintRecipe, se esta aplicando el 
concepto de responsabilidad única (RSP). La clase Recipe tenia más de una 
responsabilidad asignada, ya que a demas de crear una lista con todos los pasos 
de la receta, también los imprimía. Aplicando este concepto, creamos una clase, 
con una única responabilidad, que es imprimir la receta, usando el metodo que
se econtraba anres en la clase Recipe. 

De esta forma Recipe y ConsolePrinter tienen 
una única responsabilidad y en el caso de que se quiera agregar nuevas funciones o clases
al programa, aplicando este concepto es más facil que este se adapte a nuevos cambios 
y que lo que ya está escrito siga funcionando correctamente. 
s*/