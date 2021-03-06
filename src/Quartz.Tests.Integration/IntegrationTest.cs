#region License
/* 
 * All content copyright Terracotta, Inc., unless otherwise indicated. All rights reserved. 
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not 
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at 
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0 
 *   
 * Unless required by applicable law or agreed to in writing, software 
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT 
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations 
 * under the License.
 * 
 */
#endregion

using Common.Logging;

using NUnit.Framework;

namespace Quartz.Tests.Integration
{
    /// <summary>
    /// Base class for integration tests.
    /// </summary>
    /// <author>Marko Lahma (.NET)</author>
    [Category("integration")]    
    public abstract class IntegrationTest
    {
        protected IScheduler sched;
        private readonly ILog log;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTest"/> class.
        /// </summary>
        protected IntegrationTest()
        {
            log = LogManager.GetLogger(GetType());
        }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <value>The log.</value>
        protected ILog Log
        {
            get { return log; }
        }
    }
}
