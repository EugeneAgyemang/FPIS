using FPIS.Models;
using FPIS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works on the `Set Variable` model to perform
    /// database transactions.
    /// </summary>
    internal class SetVariableService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `SetVariableService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public SetVariableService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Adds a new `Set Variable` with ConcentrationOFNaOH, NormalityOfNaSO
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public CalculatorVariable SetNewVariable(string name, float value)
        {
            var setNewVariable = _dbContext.CalculatorVariables.Add(
                    new()
                    {
                        VariableName = name,
                        Value = value
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return setNewVariable;
        }

    }
}
