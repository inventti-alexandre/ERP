using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataLayer.Context;
using DomainLayer.DB_Model.Chart;
using DomainLayer.DB_Model.Title;
using Type = DomainLayer.DB_Model.General.Type;

namespace DataLayer.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SharpCoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SharpCoContext context)
        {




            //اگر مقدار در جداول موجود بود صرف نظر میشود
            //if (context.Type.Any()) return;

            var rootTypeId = AddChartToDb(context,-1);


            //Add Titile Table Type
            AddTitleTypeToDb(context, 200);

            
            //Add DocHistory table Type
            AddDocHistoryTypeToDb(context, 300);


            //افزودن ساختار سازمانی اولیه
            var baseChart = new Chart
            {
                ChartId = new Guid(),
                IsActive = true,
                Name = "ریشه",
                ParentId = null,
                RegisterDate = DateTime.Now,
                RegisterDateSh = FrameWork.General.Date.Getdate(),
                TypeId = rootTypeId,

            };

            if (!context.Chart.Any(s => s.ParentId == null))
            {
                context.Chart.AddOrUpdate(baseChart);
            }

        }



        private int AddChartToDb(SharpCoContext context,int startId)
        {



            var customCode=startId;
            var typeList = new List<Type>
            {

                

                new Type()
                {
                    Group = 1,
                    Code = ++customCode,
                    Order = 0,
                    Subject = "ریشه",
                    Description = "ریشه چارت سازمانی",
                    TypeId =customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },


                new Type()
                {
                    Group = 1,
                    Code =++customCode,
                    Order = 1,
                    Subject = "سازمان",
                    Description = "چارت سازمانی",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                 new Type()
                {
                    Group = 1,
                    Code = ++customCode,
                    Order = 2,
                    Subject = "واحد",
                    Description = "چارت سازمانی",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                 new Type()
                {
                    Group = 1,
                    Code = ++customCode,
                    Order=3,
                    Subject = "سمت",
                    Description = "سمت های سازمان",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                new Type()
                {
                    Group = 2,
                    Code = ++customCode,
                    Order=0,
                    Subject = "کارتابل",
                    Description = "کارتابل",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                new Type()
                {
                    Group = 2,
                    Code = ++customCode,
                    Order=1,
                    Subject = "بازیافت",
                    Description = "بازیافت",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                 new Type()
                {
                    Group = 2,
                    Code = ++customCode,
                    Order=3,
                    Subject = "پیشنویس",
                    Description = "پیشنویس",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },
            


            };




            foreach (var type in typeList)
            {
                if (!context.Type.Any(a => a.Code == type.Code))
                {
                    context.Type.AddOrUpdate(type);
                }

            }


            return typeList.Single(s=>s.TypeId==0).TypeId;

        }

        private void AddTitleTypeToDb(SharpCoContext context, int startId,int groupCode =3)
        {
            var customCode = startId;
            var typeList = new List<Type>
            {
                new Type()
                {
                    Group =groupCode ,
                    Code = ++customCode,
                    Order = 0,
                    Subject = "تایید",
                    Description = "تایید کننده سند",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },
                new Type()
                {
                    Group =groupCode ,
                    Code = ++customCode,
                    Order = 1,
                    Subject = "امضا",
                    Description = "امضا کننده سند",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },
                 new Type()
                {
                    Group =groupCode ,
                    Code = ++customCode,
                    Order = 2,
                    Subject = "ثبت",
                    Description = "ثبت کننده سند",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },

                 new Type()
                {
                    Group =groupCode ,
                    Code = ++customCode,
                    Order = 4,
                    Subject = "رونوشت",
                    Description = "رونوشت سند",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },


            };

            foreach (var type in typeList)
            {
                if (!context.Type.Any(a => a.Code == type.Code))
                {
                    context.Type.AddOrUpdate(type);
                }

            }

        }




        private void AddDocHistoryTypeToDb(SharpCoContext context, int startId, int groupCode = 4)
        {
            var customCode = startId;
            var typeList = new List<Type>
            {
                new Type()
                {
                    Group =groupCode ,
                    Code = ++customCode,
                    Order = 0,
                    Subject = "ویرایش سند",
                    Description = "سند توسط کاربری ویرایش شده است",
                    TypeId = customCode,
                    OwnerUserId = Guid.Empty,
                    RegisterDate = DateTime.Now,
                    RegisterDateSh = FrameWork.General.Date.Getdate(),
                },
               


            };

            foreach (var type in typeList)
            {
                if (!context.Type.Any(a => a.Code == type.Code))
                {
                    context.Type.AddOrUpdate(type);
                }

            }

        }


    }
}