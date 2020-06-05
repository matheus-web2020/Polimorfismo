namespace PolimorfismoAula2_POO
{
    public class Calculo
    {
        public string Calcular(){
            return "Não houve nenhum cálculo a ser aplicado";

        }
        
        public string Calcular(int vida){
            return "A vida do Jogador está com:" + vida;
        }

        public string Calcular(int vida, int escudo){
            return "A vida do jogador com escudo é:" + (vida+escudo);
        }


        public string Calcular(string nome, string sobrenome){
            return $"O nome do jogador completo é: {nome} {sobrenome}";
        }

        public string Calcular(int dano, int vida, int escudo){
            return "A Vida do jogador após sofre dano foi de:" + (vida + escudo - dano);
        }
    }
    
}