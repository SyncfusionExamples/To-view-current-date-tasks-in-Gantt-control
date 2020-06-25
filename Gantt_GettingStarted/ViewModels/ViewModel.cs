using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Controls.Gantt;
using System.Windows;

namespace EssentialGantt
{
    class ViewModel 
    {
        public ViewModel()
        {
            _taskCollection = this.GetData();
        }

        private ObservableCollection<TaskDetails> _taskCollection;

        /// <summary>
        /// Gets or sets the appointment item source.
        /// </summary>
        /// <value>The appointment item source.</value>
        public ObservableCollection<TaskDetails> TaskCollection
        {
            get
            {
                return _taskCollection;
            }
            set
            {
                _taskCollection = value;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<TaskDetails> GetData()
        {
            ObservableCollection<TaskDetails> Activities = new ObservableCollection<TaskDetails>();

            Activities.Add(new TaskDetails { StartDate = DateTime.Now, FinishDate = DateTime.Now.AddDays(16), TaskName = "Analysing Market Scope of the Product", TaskId = 1 });

            ObservableCollection<IGanttTask> MarketAnalysis = new ObservableCollection<IGanttTask>();
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-30), FinishDate = DateTime.Now.AddDays(4), TaskName = "Current Market Review", TaskId = 2 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-6), FinishDate = DateTime.Now.AddDays(9), TaskName = "Establish mislestone for future development", TaskId = 3 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-9), FinishDate = DateTime.Now.AddDays(10), TaskName = "Establish goals", TaskId = 4 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(10), FinishDate = DateTime.Now.AddDays(13), TaskName = "Sales, marketing and pricing plan", TaskId = 5 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(11), FinishDate = DateTime.Now.AddDays(14), TaskName = "Define product goals and milestones", TaskId = 6 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(12), FinishDate = DateTime.Now.AddDays(17), TaskName = "Organization status review", TaskId = 7 });
            MarketAnalysis.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(18), FinishDate = DateTime.Now.AddDays(18), TaskName = "Market Scope of Product clarified", TaskId = 8 });
            ObservableCollection<Predecessor> mrkPredecessor = new ObservableCollection<Predecessor>();
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 2, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 3, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 4, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 5, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 6, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            mrkPredecessor.Add(new Predecessor { GanttTaskIndex = 7, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            MarketAnalysis[6].Predecessor = mrkPredecessor;

            Activities[0].Child = MarketAnalysis;


            Activities.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(18), FinishDate = DateTime.Now.AddDays(44), TaskName = "Infrastructure for Product Planning", TaskId = 9 });
            ObservableCollection<IGanttTask> InfrastructureReq = new ObservableCollection<IGanttTask>();
            InfrastructureReq.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-18), FinishDate = DateTime.Now.AddDays(24), TaskName = "Define procedure for qualifying ideas", TaskId = 10 });
            InfrastructureReq.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-24), FinishDate = DateTime.Now.AddDays(37), TaskName = "Define process for idea sharing", TaskId = 11 });
            InfrastructureReq.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(37), FinishDate = DateTime.Now.AddDays(44), TaskName = "Infrastructure for Product planning Complete", TaskId = 12 });
            InfrastructureReq[1].Predecessor.Add(new Predecessor { GanttTaskIndex = 10, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            InfrastructureReq[2].Predecessor.Add(new Predecessor { GanttTaskIndex = 11, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });

            Activities[1].Child = InfrastructureReq;

            Activities.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(44), FinishDate = DateTime.Now.AddDays(87), TaskName = "Product Definition Phase", TaskId = 13 });
            ObservableCollection<IGanttTask> Product = new ObservableCollection<IGanttTask>();
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-44), FinishDate = DateTime.Now.AddDays(55), TaskName = "Identify product", TaskId = 14 });
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(58), FinishDate = DateTime.Now.AddDays(61), TaskName = "Identify need for the product", TaskId = 15 });
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-64), FinishDate = DateTime.Now.AddDays(68), TaskName = "Identify current trend for targets", TaskId = 16 });
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(64), FinishDate = DateTime.Now.AddDays(87), TaskName = "Define product use and features", TaskId = 17 });
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(64), FinishDate = DateTime.Now.AddDays(68), TaskName = "Identify competitor product", TaskId = 18 });
            Product.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-87), FinishDate = DateTime.Now.AddDays(87), TaskName = "Product Definition Complete", TaskId = 19 });
            Product[1].Predecessor.Add(new Predecessor { GanttTaskIndex = 14, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Product[2].Predecessor.Add(new Predecessor { GanttTaskIndex = 15, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Product[3].Predecessor.Add(new Predecessor { GanttTaskIndex = 16, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Product[5].Predecessor.Add(new Predecessor { GanttTaskIndex = 16, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Product[5].Predecessor.Add(new Predecessor { GanttTaskIndex = 17, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Product[5].Predecessor.Add(new Predecessor { GanttTaskIndex = 18, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Activities[2].Child = Product;

            Activities.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(92), FinishDate = DateTime.Now.AddDays(100), TaskName = "Analysing Customer Requirement", TaskId = 20 });
            ObservableCollection<IGanttTask> Customer = new ObservableCollection<IGanttTask>();
            Customer.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(92), FinishDate = DateTime.Now.AddDays(94), TaskName = "Identify Consumer of Products", TaskId = 21 });
            Customer.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(93), FinishDate = DateTime.Now.AddDays(96), TaskName = "Identify Customer Requirement", TaskId = 22 });
            Customer.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(95), FinishDate = DateTime.Now.AddDays(98), TaskName = "Analysing Customer Requiremet with current plan", TaskId = 23 });
            Customer.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(97), FinishDate = DateTime.Now.AddDays(100), TaskName = "Design based on Customer Requirement", TaskId = 24 });
            Customer.Add(new TaskDetails { StartDate = DateTime.Now.AddDays(-100), FinishDate = DateTime.Now.AddDays(100), TaskName = "Customer Requirement Analysis Complete", TaskId = 25 });
            Customer[1].Predecessor.Add(new Predecessor { GanttTaskIndex = 21, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Customer[2].Predecessor.Add(new Predecessor { GanttTaskIndex = 22, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Customer[3].Predecessor.Add(new Predecessor { GanttTaskIndex = 23, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });
            Customer[4].Predecessor.Add(new Predecessor { GanttTaskIndex = 24, GanttTaskRelationship = GanttTaskRelationship.FinishToStart });

            Activities[3].Child = Customer;

            return Activities;
        }
    }       
}