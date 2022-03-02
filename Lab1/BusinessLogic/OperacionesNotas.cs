using Lab1.Models;
using Lab1.Services;

namespace Lab1.BusinessLogic
{
    public class OperacionesNotas : IoperacionesNotas
    {
        public string NombreCompleto(ActionNotas action)
        {
            return action.Nombre;
        }

        public double PorcLab(ActionNotas action)
        {
            return action.TotalLab * 0.40;
        }

        public double PorcPar(ActionNotas action)
        {
            return action.TotalParc * 0.60;
        }

        public double Prom(ActionNotas action)
        {
            return action.Prom = (action.TotalLab *0.40) + (action.TotalParc * 0.60);
        }

        public double SumaLab(ActionNotas action)
        {
            return action.TotalLab = (action.Lab1 + action.Lab2 + action.Lab3)/3;
        }

        public double SumaPar(ActionNotas action)
        {
            return action.TotalParc = (action.Par1 + action.Par2 + action.Par3)/3;
        }

        public double TotalLab(ActionNotas action)
        {
            throw new NotImplementedException();
        }

        public double TotalParc(ActionNotas action)
        {
            throw new NotImplementedException();
        }
    }
}