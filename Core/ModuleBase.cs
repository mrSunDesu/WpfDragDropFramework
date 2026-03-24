using System;

namespace WpfDragDropFramework.Core
{
    // Abstract base class for all workflow modules
    public abstract class ModuleBase
    {
        // Abstract methods that all derived modules must implement
        public abstract void Initialize();
        public abstract void Execute();
        public abstract void Terminate();
    }
}