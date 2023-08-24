using WebAPI.Models;

namespace WebAPI.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponse<FuncionarioModel>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
        Task<ServiceResponse<FuncionarioModel>> DeleteFuncionario(int id);
        Task<ServiceResponse<FuncionarioModel>> InativaFuncionario(int id);
    }
}
