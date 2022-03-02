using Lab1.Models;
namespace Lab1.Services{

    public interface IoperacionesNotas{

        String NombreCompleto(ActionNotas action);
        Double SumaLab(ActionNotas action);
        Double SumaPar(ActionNotas action);
        Double PorcLab(ActionNotas action);
        Double PorcPar(ActionNotas action);
        Double TotalLab(ActionNotas action);
        Double TotalParc(ActionNotas action);
        Double Prom(ActionNotas action);
    }
}
