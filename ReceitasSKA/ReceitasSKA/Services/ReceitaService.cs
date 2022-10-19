using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ReceitasSKA.Data;
using ReceitasSKA.Data.Dtos.ReceitaDTO;
using ReceitasSKA.Models;
using System.Data;
using static ReceitasSKA.Util.Infomacoes;

namespace ReceitasSKA.Services
{
    public class ReceitaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ReceitaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadReceitaDto AdicionarReceita(CreateReceitaDto receitaDto)
        {
            Receita receita = _mapper.Map<Receita>(receitaDto);
            SqlConnection conexao = new SqlConnection(Informacoes.ConexaoProtheus);
            string sql = @"
                           INSERT INTO [dbo].[Z20010]
                                   ([Z20_FILIAL]
                                  ,[Z20_CODREC]
                                  ,[Z20_VEPESO]
                                  ,[Z20_LOTPAD]
                                  ,[Z20_TEMPAD]
                                  ,[Z20_CTRAB]
                                  ,[D_E_L_E_T_]
                                   ,[R_E_C_N_O_]
                                  ,[R_E_C_D_E_L_])
                            VALUES
                                  (@filial
                                  ,@CodigoReceita
                                  ,@VersaoPeso
                                  ,@LotePadrao
                                  ,@TempoPadrao
                                  ,@CodigoCT
                                  ,''
                                   ,((SELECT MAX([R_E_C_N_O_]) AS [ID] FROM [Z20010]) + 1)
                                  ,0)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.Add(new SqlParameter("@filial", receita.filial));
            comando.Parameters.Add(new SqlParameter("@CodigoReceita", receita.CodigoReceita));
            comando.Parameters.Add(new SqlParameter("@VersaoPeso", receita.VersaoPeso));
            comando.Parameters.Add(new SqlParameter("@LotePadrao", receita.LotePadrao));
            comando.Parameters.Add(new SqlParameter("@TempoPadrao", receita.TempoPadrao));
            comando.Parameters.Add(new SqlParameter("@CodigoCT", receita.CodigoCT));
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
            return _mapper.Map<ReadReceitaDto>(receita);


        //    //Receita receita = _mapper.Map<Receita>(receitaDto);
        //    //SqlConnection conn = new SqlConnection("server=172.22.201.38;database=TOTVS_PROTHEUS_TESTE_2022-07-31;user=Dba Jefferson.Murat;password=Magnus@12");
        //    //string sql = "INSERT INTO Z20010(Z20_FILIAL,Z20_CODREC,Z20_VEPESO,Z20_LOTPAD,Z20_TEMPAD,Z20_CTRAB,D_E_L_E_T_,R_E_C_N_O_ ,R_E_C_D_E_L_)" +
        //    //    "VALUES(@filial, @CodigoReceita, @VersaoPeso, @LotePadrao, @TempoPadrao, @CodigoCT, '', ((SELECT MAX([R_E_C_N_O_]) AS [ID] FROM [Z20010]) + 1), 0)";
        //    //SqlCommand comando = new SqlCommand(sql, conn);
        //    //comando.Parameters.Add(new SqlParameter("@filial", receita.filial));
        //    //comando.Parameters.Add(new SqlParameter("@CodigoReceita", receita.CodigoReceita));
        //    //comando.Parameters.Add(new SqlParameter("@VersaoPeso", receita.VersaoPeso));
        //    //comando.Parameters.Add(new SqlParameter("@LotePadrao", receita.LotePadrao));
        //    //comando.Parameters.Add(new SqlParameter("@TempoPadrao", receita.TempoPadrao));
        //    //comando.Parameters.Add(new SqlParameter("@CodigoCT", receita.CodigoCT));
        //    //conn.Open();
        //    //comando.ExecuteNonQuery();
        //    //conn.Close();
        //    //return _mapper.Map<ReadReceitaDto>(receita);


        //    //Receita receita = _mapper.Map<Receita>(receitaDto);
        //    //_context.Receitas.Add(receita);
        //    //_context.SaveChanges();
        //    //return _mapper.Map<ReadReceitaDto>(receita);

        }

        
        public IEnumerable<Receita> ConsultarReceita()
        {
            return _context.Receitas;
        }


        public ReadReceitaDto ConsultarReceitasPorID(int id)
        {
            Receita receita = _context.Receitas.FirstOrDefault(receita => receita.Id == id);
            if (receita != null)
            {
                ReadReceitaDto receitaDto = _mapper.Map<ReadReceitaDto>(receita);

                return receitaDto;
            }
            return null;
        }

        public Result AtualizarReceita(int id, UpdateReceitaDto receitaDto)
        {
            Receita receita = _context.Receitas.FirstOrDefault(receita => receita.Id == id);
            if (receita == null)
            {
                return Result.Fail("Receita não encontrada!");
            }
            _mapper.Map(receitaDto, receita);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletarReceita(int id)
        {
            Receita receita = _context.Receitas.FirstOrDefault(receita => receita.Id == id);
            if (receita == null)
            {
                return Result.Fail("Receita não encontrada");
            }
            _context.Remove(receita);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
