﻿using TTGBL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTGWebUI.Models;
using TTGModel;

namespace WebUI.Controllers
{
    public class LineItemController : Controller
    {
        private ILineItemBL _lineItemBL;
        private IProductBL _prodBL;

        public LineItemController(ILineItemBL p_lineItemBL, IProductBL p_prodBL)
        {
            _lineItemBL = p_lineItemBL;
            _prodBL = p_prodBL;
        }
        //------------------------------------Index-----------------------------------------
        public ActionResult Index(int p_storeId)
        {
            //get list of customers from BL
            //converted model customer into customerVM using select method
            //toList to change it into a list
            return View(_lineItemBL.GetAllLineItems(p_storeId)
                .Select(item => new LineItemVM(item))
                .ToList()
            );
        }
        //-------------------------------------Inventory----------------------------------------
        // GET: LineItem
        public ActionResult Inventory(int p_storeId)
        {
            ViewData.Add("CurrentStoreFront", p_storeId);
            List<LineItem> ListOfLineItems = _lineItemBL.GetAllLineItems(p_storeId);
            List<ProductVM> ProdList=new List<ProductVM>();
            List<LineItemVM> ItemList = new List<LineItemVM>();
            List<int> Quantity= new List<int>();
            for (int i=0; i< ListOfLineItems.Count; i++)
            {
                ProdList.Add(new ProductVM(_prodBL.GetProductByID(ListOfLineItems[i].Product)));
                ItemList.Add(new LineItemVM(ListOfLineItems[i]));
            }
            Tuple<IEnumerable<ProductVM>, IEnumerable<LineItemVM>> InventoryList = new Tuple<IEnumerable<ProductVM>, IEnumerable<LineItemVM>>(ProdList.AsEnumerable(), ItemList.AsEnumerable());

            return View(InventoryList);
        }
        //-----------------------------------create------------------------------------------


        //-----------------------------------Delete------------------------------------------


        //-----------------------------------Modify------------------------------------------



        //------------------------------------------------------------------------------

    }
}

