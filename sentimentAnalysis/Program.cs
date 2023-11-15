using SentimentAnalysis;

//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Rev_id = 2.429755E+08F,
    Comment = @"you are very nice",
    Logged_in = false,
    Ns = @"article",
    Sample = @"random",
    Split = @"train",
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.PredictedLabel);