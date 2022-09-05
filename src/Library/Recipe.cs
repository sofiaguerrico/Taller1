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
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        /*El método del calculo del costo de producción lo asigné en la clase de receta ya que es la que tiene la información
        que requiere el mismo*/
        public double GetProductionCost()
        {
            double total = 0;
            double insumos = 0;
            double equipamiento = 0;

            foreach (Step step in this.steps)
            {
                insumos += step.Input.UnitCost;
                equipamiento += (step.Time * (step.Equipment.HourlyCost / 60));
                total = insumos + equipamiento;
            }
            return total;
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

    }
}