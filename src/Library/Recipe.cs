//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        public IEnumerable GetSteps() 
        /*
        Se agrega este método para poder acceder al array privado de steps para luego utilizarlo en la clase ConsolePrinter.
        IEnumerable se utiliza para poder iterar sobre una secuencia de elementos,
        en este caso, la lista steps.
        Con esto puedo desde ConsolePrinter acceder a cada elemento de steps que contiene los 
        ingredientes, la cantidad, descripcion y tiempo y con ello puedo imprimir la receta. 
        */
        {
            foreach (Step step in this.steps)
            {
                yield return this.steps;
                //yield se utiliza para poder retornar los objetos de la secuencia.
            }
        }
    } 
}  