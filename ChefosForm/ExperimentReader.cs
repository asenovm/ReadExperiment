using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Read
{
    public class ExperimentReader
    {
        private List<ExperimentIteration> experimentData;

        public ExperimentReader()
        {
            experimentData = new List<ExperimentIteration>();
            System.IO.StreamReader streamReader = System.IO.File.OpenText(FileName.QUESTIONS_OFFERS);
            string experimentIterationAsString = streamReader.ReadLine();
            while (experimentIterationAsString != null)
            {
                experimentData.Add(new ExperimentIteration(experimentIterationAsString));
                experimentIterationAsString = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        public List<ExperimentIteration> GetExperimentData()
        {
            return experimentData;
        }
    }
}
