using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimbusSync.Client.Logic
{
    public class TecnicalDrawStaticDraws
    {
        #region Lists
        List<string> nomesDesenhosTecnicos = new List<string>()
            {
                "Desenho Técnico 1",
                "Desenho Técnico 2",
                "Desenho Técnico 3",
                "Desenho Técnico 4",
                "Desenho Técnico 5",
                "Desenho Técnico 6",
                "Desenho Técnico 7",
                "Desenho Técnico 8",
                "Desenho Técnico 9",
                "Desenho Técnico 10",
                "Desenho Técnico 11",
                "Desenho Técnico 12",
                "Desenho Técnico 13",
                "Desenho Técnico 14",
                "Desenho Técnico 15"
            };

        List<string> descricoesDesenhosTecnicos = new List<string>()
            {
                "Descrição do Desenho 1",
                "Descrição do Desenho 2",
                "Descrição do Desenho 3",
                "Descrição do Desenho 4",
                "Descrição do Desenho 5",
                "Descrição do Desenho 6",
                "Descrição do Desenho 7",
                "Descrição do Desenho 8",
                "Descrição do Desenho 9",
                "Descrição do Desenho 10",
                "Descrição do Desenho 11",
                "Descrição do Desenho 12",
                "Descrição do Desenho 13",
                "Descrição do Desenho 14",
                "Descrição do Desenho 15"
            };

        List<DateOnly> datasCriacaoDesenhos = new List<DateOnly>()
            {
                new DateOnly(2023, 1, 1),
                new DateOnly(2023, 1, 2),
                new DateOnly(2023, 1, 3),
                new DateOnly(2023, 1, 4),
                new DateOnly(2023, 1, 5),
                new DateOnly(2023, 1, 6),
                new DateOnly(2023, 1, 7),
                new DateOnly(2023, 1, 8),
                new DateOnly(2023, 1, 9),
                new DateOnly(2023, 1, 10),
                new DateOnly(2023, 1, 11),
                new DateOnly(2023, 1, 12),
                new DateOnly(2023, 1, 13),
                new DateOnly(2023, 1, 14),
                new DateOnly(2023, 1, 15)
            };

        List<string> caminhosFalsos = new List<string>()
            {
                "C:\\caminho\\desenho1.pdf",
                "C:\\caminho\\desenho2.pdf",
                "C:\\caminho\\desenho3.pdf",
                "C:\\caminho\\desenho4.pdf",
                "C:\\caminho\\desenho5.pdf",
                "C:\\caminho\\desenho6.pdf",
                "C:\\caminho\\desenho7.pdf",
                "C:\\caminho\\desenho8.pdf",
                "C:\\caminho\\desenho9.pdf",
                "C:\\caminho\\desenho10.pdf",
                "C:\\caminho\\desenho11.pdf",
                "C:\\caminho\\desenho12.pdf",
                "C:\\caminho\\desenho13.pdf",
                "C:\\caminho\\desenho14.pdf",
                "C:\\caminho\\desenho15.pdf"
            };

        List<string> fakeAuthorNames = new List<string>()
{
    "John Doe",
    "Jane Smith",
    "Robert Johnson",
    "Emily Brown",
    "Michael Davis",
    "Jessica Thompson",
    "David Wilson",
    "Sophia White",
    "Daniel Anderson",
    "Olivia Martinez",
    "Andrew Taylor",
    "Ava Garcia",
    "Matthew Robinson",
    "Isabella Clark",
    "William Young"
};


        #endregion
        public List<TecnicalDraw> CreateTecnicalDraws()
        {
            List<TecnicalDraw> tecnicalDraws = new List<TecnicalDraw>();

            for (int i = 0; i < nomesDesenhosTecnicos.Count; i++)
            {
                TecnicalDraw tecnicalDraw = new TecnicalDraw(
                    i.ToString(),
                    nomesDesenhosTecnicos[i],
                    descricoesDesenhosTecnicos[i],
                    datasCriacaoDesenhos[i],
                    fakeAuthorNames[i],
                    caminhosFalsos[i]
                );

                tecnicalDraws.Add(tecnicalDraw);
            }

            return tecnicalDraws;
        }


    }
}
