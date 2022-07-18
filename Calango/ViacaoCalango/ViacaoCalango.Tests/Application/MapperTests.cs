using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViacaoCalango.Application.ViewModels;
using ViacaoCalango.Domain.Entities;
using Xunit;

namespace ViacaoCalango.Tests.Application
{
    public class MapperTests
    {
        private IMapper _mapper;

        public MapperTests()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Passageiro, PassageiroViewModel>();
                cfg.CreateMap<PassageiroViewModel, Passageiro>();
            });

            _mapper = configuration.CreateMapper();
        }


        [Fact]
        public void Test1()
        {
            Passageiro passageiro = new Passageiro();
            passageiro.Nome = "Wilson Dumbledore";
            passageiro.CPF = "06987556988";
            passageiro.DataNascimento = "14/8/2000";

            var passageiroViewModel = _mapper.Map<PassageiroViewModel>(passageiro);

            Assert.Equal(passageiro.Nome, passageiroViewModel.Nome);


        }

    }
}
