# Machine Learning for .NET - Sample of sentiment analysis

Sample using [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet) for binary classification

Used the `amazon_cells_labelled.txt` of [UCI Sentiment labelled sentences dataset zip file](https://archive.ics.uci.edu/ml/datasets/Sentiment+Labelled+Sentences#)

The dataset contains:

- The file has no header;
- Two columns representing the review/sentence (index 0) and label/score (index 1);
- 1000 sentences, 50 positive and 50 negative.

**Command executed:**
```bash
mlnet classification --dataset "amazon_cells_labelled.txt" --label-col score --has-header false --train-time 10
```

- **ML task:** classification
- **dataset:** uses the dataset file amazon_cells_labelled.txt as training and testing dataset
- **has-header:** this particular dataset file doesn't have a header
- **train-time:** the targeted exploration for the experiment is 10 seconds

> *Note: for demo purposes the training time is super low*

**Generated Code:**

- SampleClassification.Model (Class Library)
    - **MLModel.zip:** ML model serialized
    - **Model Input/Output:** data classes

- SampleClassification.ConsoleApp
    - **ModelBuilder**: to train/build the model

- SampleClassification.Consume
    - Example of how to consume the zip model


More about [ML.NET](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet): https://github.com/dotnet/machinelearning
