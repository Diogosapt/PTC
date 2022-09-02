using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTC.Data
{
    public class TrainingProductViewModel
    {
        public List<TrainingProduct> Products { get; set; }

        public TrainingProduct Entity { get; set; }
        public string EventCommand { get; set; }
        public TrainingProduct SearchEntity { get; set; }
        public bool IsDetailAreaVisible{ get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }
        public bool IsValid { get; set; }
        public string Mode { get; set; }

        private void Init() 
        {
            EventCommand = "List";
            ListMode();
        }
        public TrainingProductViewModel()
        {
            Products = new List<TrainingProduct>();
            SearchEntity = new TrainingProduct();   
            Init();
        }

        public void HandleRequest() 
        {
            switch (EventCommand.ToLower()) 
            {
                case "list":
                    Get();
                    break;

                case "search":
                    Get();
                    break;

                case "save":
                    ResetSearch();
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    break;

                case "add":
                    Add();
                    break;

                default:
                    break;
            }
        }


        private void ListMode() 
        {
            IsValid = true;
            IsListAreaVisible = true;
            IsSearchAreaVisible = true;
            IsDetailAreaVisible = false;

            Mode = "List";
        }

        public void Add() 
        {
            IsValid = true;
            Entity = new TrainingProduct();
            Entity.IntroductionDate = DateTime.Now;
            Entity.Url = "Http://";
            Entity.Price = 0;

            AddMode();
        }
        private void AddMode()
        {
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            IsDetailAreaVisible = true;

            Mode = "Add";
        }
        private void ResetSearch() 
        {
            SearchEntity =  new TrainingProduct();
        }

        private void Get() 
        {
            TrainingProductManager mrg = new TrainingProductManager();
            Products = mrg.Get(SearchEntity);
        }
    }
}
