using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCarService;

namespace ProjectCarService
{
    public class CarServiceAPI
    {
        CarServiceModelContainer context = new CarServiceModelContainer();

        public void AddClient(Client client) 
        {
                context.Clients.Add(client);
                context.SaveChanges();
        }

        public void AddAuto(Auto auto)
        {
            context.Autos.Add(auto);
            context.SaveChanges();
        }

        public void AddComanda(Comanda comanda)
        {
            context.Comands.Add(comanda);
            context.SaveChanges();
        }

        public void AddDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            context.DetaliuComandas.Add(detaliuComanda);
            context.SaveChanges();
        }

        public void AddImagine(Imagine imagine)
        {
            context.Imagines.Add(imagine);
            context.SaveChanges();
        }

        public void AddMaterial(Material material)
        {
            context.Materials.Add(material);
            context.SaveChanges();
        }

        public void AddMecanic(Mecanic mecanic)
        {
            context.Mecanics.Add(mecanic);
            context.SaveChanges();
        }

        public void AddOperatie(Operatie operatie)
        {
            context.Operations.Add(operatie);
            context.SaveChanges();
        }

        public void AddSasiu(Sasiu sasiu)
        {
            context.Sasius.Add(sasiu);
            context.SaveChanges();
        }

        public void AddAuto(int clientId, Sasiu sasiu, string nrTarga, string serieSasiu)
        {
            if (serieSasiu[6] != sasiu.CodSasiu[0] || serieSasiu[7] != sasiu.CodSasiu[1])
            {
                if (context.Autos.SingleOrDefault(x => x.NumarAuto == nrTarga) != null)
                {
                    return;
                }
            }
            context.Autos.Add(new Auto {
                NumarAuto = nrTarga,
                SasiuSasiuId = sasiu.SasiuId,
                SerieSasiu = serieSasiu
            });
            context.Sasius.Add(sasiu);
            context.SaveChanges();
        }

        /// <summary>
        ///StareComanda = 1 => in Asteptare
        ///StareComanda = 2 => executata
        ///StareComanda = 3 => Refuzata la executie
        /// </summary>
        public void AddComanda(int idClient, int autoId, int kmBord, DateTime dataProgramare, string descriere)
        {
            if (dataProgramare < DateTime.Now) return;
            context.Comands.Add(new Comanda {
                StareComanda = 1,
                DataSystem = DateTime.Now,
                DataProgramare = dataProgramare,
                KmBord = kmBord,
                Descriere = descriere,
                ClientClientId = idClient,
                Client = GetClient(idClient),
            });
            context.SaveChanges();
        }

        public List<Auto> GetAllAuto()
        {
            return context.Autos.ToList();
        }

        public List<Client> GetAllClients()
        {
            return context.Clients.ToList();
        }

        public List<Comanda> GetAllComands()
        {
            return context.Comands.ToList();
        }

        public List<Material> GetAllMaterials()
        {
            return context.Materials.ToList();
        }

        public List<Mecanic> GetAllMecanics()
        {
            return context.Mecanics.ToList();
        }

        public List<DetaliuComanda> GetAllDetailsCommands()
        {
            return context.DetaliuComandas.ToList();
        }

        public List<Imagine> GetAllImagies()
        {
            return context.Imagines.ToList();
        }

        public List<Operatie> GetOperations()
        {
            return context.Operations.ToList();
        }

        public List<Sasiu> GetAllChassis()
        {
            return context.Sasius.ToList();
        }

        public Sasiu GetSasiuByCodeAndName(string code, string name)
        {
            return context.Sasius.SingleOrDefault(x => x.Denumire == name && x.CodSasiu == code);
        }

        public Client GetClient(int id)
        {
            return context.Clients.SingleOrDefault(x => x.ClientId == id);
        }

        public Sasiu GetSasiu(int id)
        {
            return context.Sasius.SingleOrDefault(x => x.SasiuId == id);
        }

        public Auto GetAuto(int id)
        {
            return context.Autos.SingleOrDefault(x => x.AutoId == id);
        }

        public List<Auto> GetAutoByClientId(int clientId)
        {
            return context.Autos.Where(x => x.ClientClientId == clientId).ToList();
        }

        public Comanda GetComanda(int id)
        {
            return context.Comands.SingleOrDefault(x => x.ComandaId == id);
        }

        public DetaliuComanda GetDetaliuComanda(int id)
        {
            return context.DetaliuComandas.SingleOrDefault(x => x.DetaliuComandaId == id);
        }

        public Imagine GetImagine(int id)
        {
            return context.Imagines.SingleOrDefault(x => x.ImagineId == id);
        }

        public Material GetMaterial(int id)
        {
            return context.Materials.SingleOrDefault(x => x.MaterialId == id);
        }

        public Mecanic GetMecanic(int id)
        {
            return context.Mecanics.SingleOrDefault(x => x.MecanicId == id);
        }

        public Operatie GetOperatie(int id)
        {
            return context.Operations.SingleOrDefault(x => x.OperatieId == id);
        }

        public void DeleteClientAutoSasiu(int idClient)
        {
            Sasiu sasiu;
            Client client = context.Clients.SingleOrDefault(x => x.ClientId == idClient);
            if (client == null) return;

            List<Auto> autos = context.Autos.Where(x => x.ClientClientId == idClient).ToList();
            if (autos == null) return;
            foreach (var auto in autos)
            {
                sasiu = context.Sasius.SingleOrDefault(s => s.SasiuId == auto.SasiuSasiuId);
                context.Sasius.Remove(sasiu);
                context.SaveChanges();
                context.Autos.Remove(auto);
                context.SaveChanges();
            }

            context.Clients.Remove(client);
            context.SaveChanges();
        }

        public void DeleteClient(int clientId)
        {
            Client client = context.Clients.SingleOrDefault(c => c.ClientId == clientId);
            if (client == null) return;
            context.Clients.Remove(client);
            context.SaveChanges();
        }

        public void DeleteAuto(int autoId)
        {
            Auto auto = context.Autos.SingleOrDefault(a => a.AutoId == autoId);
            if (auto == null) return;
            context.Autos.Remove(auto);
            context.SaveChanges();
        }

        public void DeleteComanda(int comandaId)
        {
            Comanda comanda = context.Comands.SingleOrDefault(c => c.ComandaId == comandaId);
            if (comanda == null) return;
            context.Comands.Remove(comanda);
            context.SaveChanges();
        }

        public void DeleteMaterial(int materialId)
        {
            Material material = context.Materials.SingleOrDefault(m => m.MaterialId == materialId);
            if (material == null) return;
            context.Materials.Remove(material);
            context.SaveChanges();
        }

        public void DeleteMecanic(int mecanicId)
        {
            Mecanic mecanic = context.Mecanics.SingleOrDefault(m => m.MecanicId == mecanicId);
            if (mecanic == null) return;
            context.Mecanics.Remove(mecanic);
            context.SaveChanges();
        }

        public void DeleteOperatie(int operatieId)
        {
            Operatie operatie = context.Operations.SingleOrDefault(o => o.OperatieId == operatieId);
            if (operatie == null) return;
            context.Operations.Remove(operatie);
            context.SaveChanges();
        }

        public void DeleteSasiu(int sasiuId)
        {
            Sasiu sasiu = context.Sasius.SingleOrDefault(s => s.SasiuId== sasiuId);
            if (sasiu == null) return;
            context.Sasius.Remove(sasiu);
            context.SaveChanges();
        }

        public void DeleteDetaliuComanda(int detaliuComandaId)
        {
            DetaliuComanda detaliuComanda = context.DetaliuComandas.SingleOrDefault(d => d.DetaliuComandaId == detaliuComandaId);
            if (detaliuComanda == null) return;
            context.DetaliuComandas.Remove(detaliuComanda);
            context.SaveChanges();
        }

        public void DeleteImage(int imagineId)
        {
            Imagine imagine = context.Imagines.SingleOrDefault(i => i.ImagineId == imagineId);
            if (imagine == null) return;
            context.Imagines.Remove(imagine);
            context.SaveChanges();
        }

        public void UpdateClient(Client client)
        { 
            context.Entry(client).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void UpdateAuto(Auto auto)
        {

            context.SaveChanges();
        }

        public void UpdateComanda(Comanda comanda)
        {
            var result = context.Comands.SingleOrDefault(c => c.ComandaId == comanda.ComandaId);

            if (result == null) return;

            result = comanda;
            context.SaveChanges();
        }

        public void UpdateDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            var result = context.DetaliuComandas.SingleOrDefault(
                c => c.DetaliuComandaId == detaliuComanda.DetaliuComandaId);

            if (result == null) return;

            result = detaliuComanda;
            context.SaveChanges();
        }

        public void UpdateImaine(Imagine imagine)
        {
            var result = context.Imagines.SingleOrDefault(
                c => c.ImagineId == imagine.ImagineId);

            if (result == null) return;

            result = imagine;
            context.SaveChanges();
        }

        public void UpdateMaterial(Material material)
        {
            var result = context.Materials.SingleOrDefault(
                c => c.MaterialId == material.MaterialId);

            if (result == null) return;

            result = material;
            context.SaveChanges();
        }
        
        public void UpdateMecanic(Mecanic mecanic)
        {
            var result = context.Mecanics.SingleOrDefault(
                c => c.MecanicId == mecanic.MecanicId);

            if (result == null) return;

            result = mecanic;
            context.SaveChanges();
        }

        public void UpdateOperatie(Operatie operatie)
        {
            var result = context.Operations.SingleOrDefault(
                c => c.OperatieId == operatie.OperatieId);

            if (result == null) return;

            result = operatie;
            context.SaveChanges();
        }

        public void UpdateSasiu(Sasiu sasiu)
        {
            var result = context.Sasius.SingleOrDefault(
                c => c.SasiuId == sasiu.SasiuId);

            if (result == null) return;

            result = sasiu;
            context.SaveChanges();
        }
    }
}
