﻿using System;
using MVVMEx04.Model;
using ViewModel.Data.Implementation;

namespace MVVMEx04.ViewModel
{
    /// <summary>
    /// The Data View Model class provides properties for Data Binding
    /// in the Details part of the view, and for each item in the list
    /// view collection. It also handles (a very modest) data validation
    /// and transformation.
    /// </summary>
    public class MovieDataViewModel : DataViewModelBase<Movie>
    {
        #region Constructor
        public MovieDataViewModel(Movie obj) : base(obj)
        {
        }
        #endregion

        #region Properties for Data Binding
        public string Title
        {
            get { return DataObject.Title; }
            set
            {
                DataObject.Title = value;
                OnPropertyChanged();
            }
        }

        public string Year
        {
            get { return DataObject.Year.ToString(); }
            set
            {
                if (int.TryParse(value, out var year))
                {
                    DataObject.Year = year;
                }
                else
                {
                    throw new ArgumentException("Illegal value in Year field");
                }
            }
        }

        public string RunningTimeInMins
        {
            get { return DataObject.RunningTimeInMins.ToString(); }
            set
            {
                if (int.TryParse(value, out var runTime))
                {
                    DataObject.RunningTimeInMins = runTime;
                }
                else
                {
                    throw new ArgumentException("Illegal value in RunningTimeInMins field");
                }
            }
        }

        public string StudioName
        {
            get { return DataObject.StudioName; }
            set
            {
                DataObject.StudioName = value;
            }
        }
        #endregion
    }
}