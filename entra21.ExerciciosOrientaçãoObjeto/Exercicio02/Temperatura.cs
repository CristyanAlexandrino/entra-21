using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class Temperatura
    {
        public double TemperaturaOrigem;
        public double TemperaturaDestino;
        public double ValorTemperatura;
        
       
        public double CelsiusParaKelvin()
        {
            double celsiusParaKelvin = ValorTemperatura + 273.15;
            return celsiusParaKelvin;

        }
        public double CelsiusParaFahreinheit()
        {

            double celsiusParaFahrenheit = ValorTemperatura * 1.8 + 32;
            return celsiusParaFahrenheit;

        }
        public double KelvinParaCelsius()
        {
            double kelvinParaCelsius = ValorTemperatura - 273.00;
            return kelvinParaCelsius;

        }
        public void KelvinParaFahreinheit()
        {
            double kelvinParaFahrenheit = (ValorTemperatura - 273) * 1.8 + 32;

        }
        public void FahreinheitParaCelsius()
        {
            double fahrenheitParaCelsius = (ValorTemperatura - 32) / 1.8;

        }
        public void FahreinheitParaKelvin()
        {


        }
        public void ObterTemperaturaConvertida()
        {


        }
    }
}
