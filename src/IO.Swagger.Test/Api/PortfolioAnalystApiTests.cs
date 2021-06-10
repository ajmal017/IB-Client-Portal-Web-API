/* 
 * Client Portal Web API
 *
 * Client Portal Web API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PortfolioAnalystApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortfolioAnalystApiTests
    {
        private PortfolioAnalystApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortfolioAnalystApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortfolioAnalystApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortfolioAnalystApi
            //Assert.IsInstanceOfType(typeof(PortfolioAnalystApi), instance, "instance is a PortfolioAnalystApi");
        }

        
        /// <summary>
        /// Test PaPerformancePost
        /// </summary>
        [Test]
        public void PaPerformancePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.PaPerformancePost(body);
            //Assert.IsInstanceOf<Performance> (response, "response is Performance");
        }
        
        /// <summary>
        /// Test PaSummaryPost
        /// </summary>
        [Test]
        public void PaSummaryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.PaSummaryPost(body);
            //Assert.IsInstanceOf<Summary> (response, "response is Summary");
        }
        
        /// <summary>
        /// Test PaTransactionsPost
        /// </summary>
        [Test]
        public void PaTransactionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.PaTransactionsPost(body);
            //Assert.IsInstanceOf<Transactions> (response, "response is Transactions");
        }
        
    }

}
