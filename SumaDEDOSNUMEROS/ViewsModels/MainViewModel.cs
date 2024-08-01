using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDEDOSNUMEROS.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _Num1;

        [ObservableProperty]
        private double _Num2;

        [ObservableProperty]
        private string? _Resultado;

        [RelayCommand]

        public void Sumar()
        {
            double Sumar = Num1 + Num2;
            Resultado = Sumar.ToString("F2");
        }
    }
}
