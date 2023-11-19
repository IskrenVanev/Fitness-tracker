﻿namespace Fitness_Tracker.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IBodyRepository Body { get; }
        IIngredientRepository Ingredient { get; }
        IMacroRepository Macro { get; }
        IRecipeRepository Recipe { get; }
        IUserRepository User { get; }
        IInstructionRepository Instruction { get; }
        IDailyCaloriesRepository DailyCalories { get; }

        void Save();
        Task SaveAsync();
        
    }
}
