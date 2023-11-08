using LojaAgricolaAppWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace LojaAgricolaAppWeb.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Maquinas> ListaMaquina { get; private set; }

        public void OnGet()
        {
            ViewData["Title"] = "Página principal";

            ListaMaquina = new List<Maquinas>
            {
                new Maquinas
                {
                    MaquinaId = 1,
                    Nome = "Trator",
                    Descricao = "Trator potente no campo verde.",
                    ImagemUri = "images/imageTratorVerde.jpg",
                    DataCadastro = DateTime.Now,
                    Preco = 100000.00,
                },

                new Maquinas
                {
                    MaquinaId = 2,
                    Nome = "Máquina agrícola",
                    Descricao = "Uma máquina agrícola laranja se destaca no campo com sua cor vibrante.",
                    ImagemUri = "images/MaquinaAgricolaLaranja.png",
                    DataCadastro = DateTime.Now,
                    Preco = 400000.00,
                },

                new Maquinas
                {
                    MaquinaId = 3,
                    Nome = "Plantadeira",
                    Descricao = "A plantadeira laranja semeia com precisão, destacando-se no campo.",
                    ImagemUri = "images/MaquinaAgricolaPlantadeira.png",
                    DataCadastro = DateTime.Now,
                    Preco = 135000.00,
                },

                new Maquinas
                {
                    MaquinaId = 4,
                    Nome = "Plantadeira",
                    Descricao = "A plantadeira laranja é uma máquina agrícola essencial, com seu brilho vibrante e capacidade de semear com precisão, tornando-a uma presença marcante no campo.",
                    ImagemUri = "images/MaquinaAgricolaPlantadeiraLaranja.png",
                    DataCadastro = DateTime.Now,
                    Preco = 350000.00,
                },

                new Maquinas
                {
                    MaquinaId = 5,
                    Nome = "Plantadeira vermelha",
                    Descricao = "A plantadeira vermelha se destaca no campo com sua cor viva e eficiência na semeadura.",
                    ImagemUri = "images/MaquinaAgricolaPlantadeiraVermelha.png",
                    DataCadastro = DateTime.Now,
                    Preco = 20000.00,
                },

                new Maquinas
                {
                    MaquinaId = 6,
                    Nome = "Trator",
                    Descricao = "Trator potente no campo verde.",
                    ImagemUri = "images/MaquinaAgricolaTratorAzul.png",
                    DataCadastro = DateTime.Now,
                    Preco = 500000.00,
                }
            };
        }
    }
}
