﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Conclúido")]
        Concluído = 3
    }
}
