using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AspNetMvc.Domain.Entities;
using AspNetMvc.MVC.ViewModels;
using AspNetMvc.Application.Interface;

namespace AspNetMvc.MVCProject.Controllers
{
    public class ClientController : Controller
    {
        private readonly IAppClientService _clientService;

        public ClientController(IAppClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: Client
        public ActionResult Index()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientService.GetAll());
            return View(clientViewModel);
        }

        public ActionResult Especiais()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientService.ObterClientesEspeciais());
            return View(clientViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                _clientService.Add(clientDomain);

                return RedirectToAction("Index");
            }
            return View(client);

        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                _clientService.Update(clientDomain);

                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientService.GetById(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = _clientService.GetById(id);

            _clientService.Remove(client);

            return RedirectToAction("Index");
        }
    }
}
