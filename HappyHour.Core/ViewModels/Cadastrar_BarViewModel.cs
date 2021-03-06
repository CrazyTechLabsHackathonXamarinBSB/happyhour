﻿using Cirrious.MvvmCross.ViewModels;
using HappyHour.Core.Models;
using HappyHour.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour.Core.ViewModels
{
    public class Cadastrar_BarViewModel : MainViewModel
    {
        public Cadastro_Bar local { get; set; }
        public MvxCommand CadastrarBarCommand { get; private set; }

        public Cadastrar_BarViewModel()
        {
            CadastrarBarCommand = new MvxCommand(ExecuteCadastrarBarCommand);
            Cadastro_Bar local = new Cadastro_Bar();
        }

        private void ExecuteCadastrarBarCommand()
        {
            Database db = new Database();
            db.InserirBarLocal(local);
        }
    }
}
