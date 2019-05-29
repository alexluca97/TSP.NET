using PostComment;
using PostComment.APIStatic;
using ProjectCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        ProjectCarService.CarServiceAPI carService = new CarServiceAPI();
        public void AddAuto(Auto auto)
        {
            carService.AddAuto(auto);
        }

        //public void AddAuto(int clientId, Sasiu sasiu, string nrTarga, string serieSasiu)
        //{
        //    AddAuto(clientId, sasiu, nrTarga, serieSasiu);
        //}

        public void AddClient(Client client)
        {
            carService.AddClient(client);
        }

        public void AddComanda(Comanda comanda)
        {
            carService.AddComanda(comanda);
        }

        //public void AddComanda(int idClient, int autoId, int kmBord, DateTime dataProgramare, string descriere)
        //{
        //    AddComanda(idClient, autoId, kmBord, dataProgramare, descriere);
        //}

        public void AddDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            carService.AddDetaliuComanda(detaliuComanda);
        }

        public void AddImage(Imagine imagine)
        {
            carService.AddImagine(imagine);

        }

        public void AddMaterial(Material material)
        {
            carService.AddMaterial(material);
        }

        public void AddMecanic(Mecanic mecanic)
        {
            carService.AddMecanic(mecanic);
        }

        public void AddOperatie(Operatie operatie)
        {
            carService.AddOperatie(operatie);
        }

        public void AddSasiu(Sasiu sasiu)
        {
            carService.AddSasiu(sasiu);
        }

        public void DeleteAuto(int autoId)
        {
            carService.DeleteAuto(autoId);
        }

        public void DeleteClient(int clientId)
        {
            carService.DeleteClient(clientId);
        }

        public void DeleteClientAutoSasiu(int idClient)
        {
            carService.DeleteClientAutoSasiu(idClient);
        }

        public void DeleteComanda(int comandaId)
        {
            carService.DeleteComanda(comandaId);
        }

        public void DeleteDetaliuComanda(int detaliuComandaId)
        {
            carService.DeleteDetaliuComanda(detaliuComandaId);
        }

        public void DeleteImage(int imagineId)
        {
            carService.DeleteImage(imagineId);
        }

        public void DeleteMaterial(int materialId)
        {
            carService.DeleteMaterial(materialId);
        }

        public void DeleteMecanic(int mecanicId)
        {
            carService.DeleteMecanic(mecanicId);
        }

        public void DeleteOperatie(int operatieId)
        {
            carService.DeleteOperatie(operatieId);
        }

        public void DeleteSasiu(int sasiuId)
        {
            carService.DeleteSasiu(sasiuId);
        }

        public List<Auto> GetAllAuto()
        {
            return carService.GetAllAuto();
        }

        public List<Sasiu> GetAllChassis()
        {
            return carService.GetAllChassis();
        }

        public List<Client> GetAllClients()
        {
            return carService.GetAllClients();
        }

        public List<Comanda> GetAllComands()
        {
            return carService.GetAllComands();
        }

        public List<DetaliuComanda> GetAllDetailsCommands()
        {
            return carService.GetAllDetailsCommands();
        }

        public List<Imagine> GetAllImagies()
        {
            return carService.GetAllImagies();
        }

        public List<Material> GetAllMaterials()
        {
            return carService.GetAllMaterials();
        }

        public List<Mecanic> GetAllMecanics()
        {
            return carService.GetAllMecanics();
        }

        public Auto GetAuto(int id)
        {
            return carService.GetAuto(id);
        }

        public List<Auto> GetAutoByClientId(int clientId)
        {
            return carService.GetAutoByClientId(clientId);
        }

        public Client GetClient(int id)
        {
            return carService.GetClient(id);
        }

        public Comanda GetComanda(int id)
        {
            return carService.GetComanda(id);
        }

        public DetaliuComanda GetDetaliuComanda(int id)
        {
            return carService.GetDetaliuComanda(id);
        }

        public Imagine GetImagine(int id)
        {
            return carService.GetImagine(id);
        }

        public Material GetMaterial(int id)
        {
            return carService.GetMaterial(id);
        }

        public Mecanic GetMecanic(int id)
        {
            return carService.GetMecanic(id);
        }

        public Operatie GetOperatie(int id)
        {
            return carService.GetOperatie(id);
        }

        public List<Operatie> GetOperations()
        {
            return carService.GetOperations();
        }

        public Sasiu GetSasiu(int id)
        {
            return carService.GetSasiu(id);
        }

        public Sasiu GetSasiuByCodeAndName(string code, string name)
        {
            return carService.GetSasiuByCodeAndName(code, name);
        }

        public void UpdateAuto(Auto auto)
        {
            carService.UpdateAuto(auto);
        }

        public void UpdateClient(Client client)
        {
            carService.UpdateClient(client);
        }

        public void UpdateComanda(Comanda comanda)
        {
            carService.UpdateComanda(comanda);
        }

        public void UpdateDetaliuComanda(DetaliuComanda detaliuComanda)
        {
            carService.UpdateDetaliuComanda(detaliuComanda);
        }

        public void UpdateImaine(Imagine imagine)
        {
            carService.UpdateImaine(imagine);
        }

        public void UpdateMaterial(Material material)
        {
            carService.UpdateMaterial(material);
        }

        public void UpdateMecanic(Mecanic mecanic)
        {
            carService.UpdateMecanic(mecanic);
        }

        public void UpdateOperatie(Operatie operatie)
        {
            carService.UpdateOperatie(operatie);
        }

        public void UpdateSasiu(Sasiu sasiu)
        {
            carService.UpdateSasiu(sasiu);
        }
    }

}
