using FPIS.Models;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FPIS.Services
{
    /// <summary>
    /// This class represents a service that works the `Products` models to perform
    /// database transactions.
    /// </summary>
    public class ProductService
    {
        private readonly AppDbContext _dbContext;


        /// <summary>
        /// Constructor initialize a new `ProductService` with a DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Returns a single product by the name
        /// </summary>
        /// <returns>Product?</returns>
        public Product? GetProductByName(string productName)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductName == productName);
        }

        /// <summary>
        /// Returns all products
        /// </summary>
        /// <returns>List<Product></returns>
        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        /// <summary>
        /// Returns all products of the given type
        /// </summary>
        /// <param name="type">The type of products needed</param>
        /// <returns></returns>
        public List<Product> GetProductsByType(string type)
        {
            return _dbContext.Products.
                            Where(product => product.Type.ToLower() == type).
                            ToList();
        }

        /// <summary>
        /// Checks if a product name exists already.
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public bool DoesProductExists(string productName)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.ProductName.ToLower() == productName.ToLower());

            if (product != null)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Creates a new `Product` with a product name
        /// </summary>
        /// <param name="productName"></param>
        public Product CreateProduct(string productName, string type)
        {
            var product = _dbContext.Products.Add(
                    new()
                    {
                        ProductName = productName,
                        Type = type
                    }
                ).Entity;

            _dbContext.SaveChanges();

            return product;
        }

        public List<SampleDetail> GetProductsWithAnalysisResults(Guid? sampleDetailId)
        {
            IQueryable<SampleDetail> samplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(sample => sample.Sample.Status.ToLower() == "completed" || sample.Sample.Status.ToLower() == "completed with rejections").
                OrderByDescending(sample => sample.Sample.Date).
                ThenByDescending(sample => sample.Sample.Time).
                Include(sample => sample.Sample.SampleResults).
                Where(a => a.AnalysisItem.ItemType == "Product").
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).

                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (sampleDetailId != null)
            {
                samplesRequestedQuery = samplesRequestedQuery.
                Where(a => a.Id == sampleDetailId);
            }


            return samplesRequestedQuery.ToList();

        }

        public List<SampleDetail> GetProductsWithAnalysisResultsForToday(DateOnly fromDate, DateOnly toDate, string productName = "")
        {
            IQueryable<SampleDetail> productSamplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(a => a.Sample.Date >= fromDate && a.Sample.Date <= toDate).
                Where(a => a.Sample.Status != "Pending").
                Where(a => a.AnalysisItem.ItemType == "Product").
                OrderByDescending(sample => sample.Sample.Date).
                ThenByDescending(sample => sample.Sample.Time).
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (productName != string.Empty)
            {
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                Where(a => a.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName == productName);

            }


            return productSamplesRequestedQuery.ToList();

        }

        public List<SampleDetail> GetProductsWithAnalysisResultsPerDate(DateOnly fromDate, DateOnly toDate, string productName = "")
        {
            IQueryable<SampleDetail> productSamplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(a => a.Sample.Date >= fromDate && a.Sample.Date <= toDate).
                Where(a => a.Sample.Status != "Pending").
                Where(a => a.AnalysisItem.ItemType == "Product").
                OrderByDescending(sample => sample.Sample.Date).
                ThenByDescending(sample => sample.Sample.Time).
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (productName != string.Empty)
            {
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                Where(a => a.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName == productName);

            }


            return productSamplesRequestedQuery.ToList();

        }

        public List<SampleDetail> GetProductsWithAnalysisResultsPerTime(DateOnly fromDate, DateOnly toDate, TimeOnly fromTime, TimeOnly toTime, string productName = "")
        {
            IQueryable<SampleDetail> productSamplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(a => a.Sample.Date >= fromDate && a.Sample.Date <= toDate).
                Where(sr => sr.Sample.Time >= fromTime && sr.Sample.Time <= toTime).
                Where(a => a.Sample.Status != "Pending").
                Where(a => a.AnalysisItem.ItemType == "Product").
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (productName != string.Empty)
            {
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                Where(a => a.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName == productName);

            }


            return productSamplesRequestedQuery.ToList();

        }

        public List<SampleDetail> GetProductsWithAnalysisResultsPerDateAndAnalysisType(DateOnly fromDate, DateOnly toDate, string analysisType,string productName = "")
        {
            IQueryable<SampleDetail> productSamplesRequestedQuery = _dbContext.SampleDetails.
                Include(sd => sd.Sample).
                Where(a => a.Sample.Date >= fromDate && a.Sample.Date <= toDate && a.Sample.TypeForFiltering == analysisType).
                Include(analysisItem => analysisItem.AnalysisItem.AnalysisProducts).
                ThenInclude(analysisProduct => analysisProduct.Product.ProductParameters).
                ThenInclude(a => a.ProductAnalysisParameters).
                ThenInclude(a => a.AnalysisParameter.sampleResultsDetailsWithParameters).
                ThenInclude(a => a.SampleResultDetail.SampleResult);


            if (productName != string.Empty)
            {
                productSamplesRequestedQuery = productSamplesRequestedQuery.
                Where(a => a.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName == productName);

            }


            return productSamplesRequestedQuery.ToList();

        }

        /// <summary>
        /// Returns a product with the given id
        /// </summary>
        /// <param name="type">The type of products needed</param>
        /// <returns></returns>
        public Product GetProductById(Guid Id)
        {
            return _dbContext.Products.
                            FirstOrDefault(product => product.Id == Id);
        }
    }
}
