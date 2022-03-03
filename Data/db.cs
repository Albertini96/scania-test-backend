using System.Collections.Generic;
using backend._Models;

namespace backend.Data
{
    public class db
    {
        public db(){}
        public List<Caminhao> getCaminhoes(){
            
            List<Caminhao> ret = new List<Caminhao>();
            
            ret.Add(new Caminhao(1, "gasolina", 32444, 30));
            ret.Add(new Caminhao(2, "disel", 23423, 32));
            ret.Add(new Caminhao(3, "alcool", 42355, 12));
            ret.Add(new Caminhao(4, "disel", 555555, 53));
            ret.Add(new Caminhao(5, "disel", 42355, 21));
            ret.Add(new Caminhao(6, "alcool", 33333, 55));
            
            return ret;
        }


        public List<Carro> getCarros(){
            
            List<Carro> ret = new List<Carro>();
            
            ret.Add(new Carro(1, "gasolina", 3411, "azul"));
            ret.Add(new Carro(2, "gasolina", 4333, "vermelho"));
            ret.Add(new Carro(3, "gasolina", 1111, "prata"));
            ret.Add(new Carro(4, "gasolina", 1999, "verde"));
            ret.Add(new Carro(5, "alcool", 4399, "prata"));
            ret.Add(new Carro(6, "alcool", 1299, "preto"));
            ret.Add(new Carro(7, "alcool", 4000, "prata"));
            
            return ret;
        }
    }
}