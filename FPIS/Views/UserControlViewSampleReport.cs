using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class UserControlViewSampleReport : UserControl
    {
        public UserControlViewSampleReport()
        {
            InitializeComponent();
            LoadProductAnalyticalResult();
        }

        
        private void LoadProductAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();
                var analysisItem = from Product in dbContext.Products
                                   //where Product.ProductName == _analysisItem
                                   from AnalysisProduct in dbContext.AnalysisProducts
                                   where AnalysisProduct.ProductId == Product.Id
                                   from SampleDetail in dbContext.SampleDetails

                                       //where SampleDetail.Id == _sampleDetailID
                                   from Sample in dbContext.Samples
                                   where Sample.Id == SampleDetail.SampleId

                                   from SampleResult in dbContext.SampleResults
                                   where SampleResult.SampleId == Sample.Id
                                   //where SampleResult.Id == _sampleResultID

                                   from SampleResultDetail in dbContext.SampleResultDetails
                                       // where SampleResultDetail.SampleResultId == _sampleResultID

                                   from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                   where SampleResultsDetailsWithParameter.SampleResultDetailId == SampleResultDetail.Id

                                   from ProductParameter in dbContext.ProductParameters
                                   where ProductParameter.ProductId == Product.Id

                                   from ProductAnalysisParameter in dbContext.ProductAnalysisParameters
                                   where ProductAnalysisParameter.ProductParameterId == ProductParameter.Id

                                   where SampleResultsDetailsWithParameter.AnalysisParameterId == ProductAnalysisParameter.AnalysisParameterId


                                   select new
                                   {
                                       analysisProduct = Product.ProductName
                                   };



                var analysisResult = from Product in dbContext.Products
                                     //where Product.ProductName == _analysisItem
                                     from AnalysisProduct in dbContext.AnalysisProducts
                                     where AnalysisProduct.ProductId == Product.Id
                                     from SampleDetail in dbContext.SampleDetails
                                         
                                     //where SampleDetail.Id == _sampleDetailID
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == Sample.Id
                                     //where SampleResult.Id == _sampleResultID
                                    
                                     from SampleResultDetail in dbContext.SampleResultDetails
                                    // where SampleResultDetail.SampleResultId == _sampleResultID
                                    
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == SampleResultDetail.Id

                                     from ProductParameter in dbContext.ProductParameters
                                     where ProductParameter.ProductId == Product.Id

                                     from ProductAnalysisParameter in dbContext.ProductAnalysisParameters
                                     where ProductAnalysisParameter.ProductParameterId == ProductParameter.Id
                                     
                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == ProductAnalysisParameter.AnalysisParameterId

                                     select new
                                     {
                                         product = Product.ProductName,
                                         parameter = ProductParameter.ParameterName,
                                         units = ProductParameter.Unit,
                                         specification_range = $"{(ProductParameter.MinimumSpecification == null ? "<= " + ProductParameter.Specification : ProductParameter.MinimumSpecification + " - " + ProductParameter.Specification)}",
                                         specification = ProductParameter.Specification,
                                         result = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : SampleResultsDetailsWithParameter.Value)}",
                                         //variance = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (float)Math.Round(Convert.ToDecimal(ProductParameter.Specification - SampleResultsDetailsWithParameter.Value), 2))}",
                                         //indicator = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (float)Math.Round(Convert.ToDecimal(ProductParameter.Specification - SampleResultsDetailsWithParameter.Value), 2))}"
                                         requestDate = Sample.Date,
                                         resultsDate = SampleResult.Date,
                                         sampleDetailID = SampleDetail.Id,
                                         sampleResultsID = SampleResult.Id
                                     };
                dataGridViewSampleResults.Rows.Clear();
                foreach (var prod in analysisItem)
                {
                    dataGridViewSampleResults.Rows.Add(prod.analysisProduct);
                    foreach (var items in analysisResult)
                    {
                        dataGridViewSampleResults.Rows.Add(items.parameter, items.units, items.specification_range, items.result, items.requestDate, items.resultsDate, items.sampleDetailID, items.sampleResultsID);
                    }
                }
               
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }
    }
}
