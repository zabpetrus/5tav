using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.AppService
{
    public class AlunoAppService
    {
        private Aluno _aluno;

        private IAlunoService _alunoService;

        public AlunoAppService() { } //Construtor da página

        public AlunoAppService (IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }


        public AlunoResultViewModel GetAluno( int idAluno )
        {
            //throw new NotImplementedException();

           // AlunoResultViewModel alunovm = new AlunoResultViewModel();
           // alunovm.setMatricula("123456");
           // return alunovm;

            Aluno aluno = _alunoService.GetById( idAluno );
            AlunoResultViewModel alunoResult = new AlunoResultViewModel();
            alunoResult.setMatricula(aluno.getMatricula());
            return alunoResult;
        }

      

        


    }
}
