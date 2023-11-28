// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The TableParameterSubspace. </summary>
    public partial class TableParameterSubspace
    {
        /// <summary> Initializes a new instance of <see cref="TableParameterSubspace"/>. </summary>
        public TableParameterSubspace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableParameterSubspace"/>. </summary>
        /// <param name="booster"> Specify the boosting type, e.g gbdt for XGBoost. </param>
        /// <param name="boostingType"> Specify the boosting type, e.g gbdt for LightGBM. </param>
        /// <param name="growPolicy"> Specify the grow policy, which controls the way new nodes are added to the tree. </param>
        /// <param name="learningRate"> The learning rate for the training procedure. </param>
        /// <param name="maxBin"> Specify the Maximum number of discrete bins to bucket continuous features . </param>
        /// <param name="maxDepth"> Specify the max depth to limit the tree depth explicitly. </param>
        /// <param name="maxLeaves"> Specify the max leaves to limit the tree leaves explicitly. </param>
        /// <param name="minDataInLeaf"> The minimum number of data per leaf. </param>
        /// <param name="minSplitGain"> Minimum loss reduction required to make a further partition on a leaf node of the tree. </param>
        /// <param name="modelName"> The name of the model to train. </param>
        /// <param name="nEstimators"> Specify the number of trees (or rounds) in an model. </param>
        /// <param name="numLeaves"> Specify the number of leaves. </param>
        /// <param name="preprocessorName"> The name of the preprocessor to use. </param>
        /// <param name="regAlpha"> L1 regularization term on weights. </param>
        /// <param name="regLambda"> L2 regularization term on weights. </param>
        /// <param name="subsample"> Subsample ratio of the training instance. </param>
        /// <param name="subsampleFreq"> Frequency of subsample. </param>
        /// <param name="treeMethod"> Specify the tree method. </param>
        /// <param name="withMean"> If true, center before scaling the data with StandardScalar. </param>
        /// <param name="withStd"> If true, scaling the data with Unit Variance with StandardScalar. </param>
        internal TableParameterSubspace(string booster, string boostingType, string growPolicy, string learningRate, string maxBin, string maxDepth, string maxLeaves, string minDataInLeaf, string minSplitGain, string modelName, string nEstimators, string numLeaves, string preprocessorName, string regAlpha, string regLambda, string subsample, string subsampleFreq, string treeMethod, string withMean, string withStd)
        {
            Booster = booster;
            BoostingType = boostingType;
            GrowPolicy = growPolicy;
            LearningRate = learningRate;
            MaxBin = maxBin;
            MaxDepth = maxDepth;
            MaxLeaves = maxLeaves;
            MinDataInLeaf = minDataInLeaf;
            MinSplitGain = minSplitGain;
            ModelName = modelName;
            NEstimators = nEstimators;
            NumLeaves = numLeaves;
            PreprocessorName = preprocessorName;
            RegAlpha = regAlpha;
            RegLambda = regLambda;
            Subsample = subsample;
            SubsampleFreq = subsampleFreq;
            TreeMethod = treeMethod;
            WithMean = withMean;
            WithStd = withStd;
        }

        /// <summary> Specify the boosting type, e.g gbdt for XGBoost. </summary>
        public string Booster { get; set; }
        /// <summary> Specify the boosting type, e.g gbdt for LightGBM. </summary>
        public string BoostingType { get; set; }
        /// <summary> Specify the grow policy, which controls the way new nodes are added to the tree. </summary>
        public string GrowPolicy { get; set; }
        /// <summary> The learning rate for the training procedure. </summary>
        public string LearningRate { get; set; }
        /// <summary> Specify the Maximum number of discrete bins to bucket continuous features . </summary>
        public string MaxBin { get; set; }
        /// <summary> Specify the max depth to limit the tree depth explicitly. </summary>
        public string MaxDepth { get; set; }
        /// <summary> Specify the max leaves to limit the tree leaves explicitly. </summary>
        public string MaxLeaves { get; set; }
        /// <summary> The minimum number of data per leaf. </summary>
        public string MinDataInLeaf { get; set; }
        /// <summary> Minimum loss reduction required to make a further partition on a leaf node of the tree. </summary>
        public string MinSplitGain { get; set; }
        /// <summary> The name of the model to train. </summary>
        public string ModelName { get; set; }
        /// <summary> Specify the number of trees (or rounds) in an model. </summary>
        public string NEstimators { get; set; }
        /// <summary> Specify the number of leaves. </summary>
        public string NumLeaves { get; set; }
        /// <summary> The name of the preprocessor to use. </summary>
        public string PreprocessorName { get; set; }
        /// <summary> L1 regularization term on weights. </summary>
        public string RegAlpha { get; set; }
        /// <summary> L2 regularization term on weights. </summary>
        public string RegLambda { get; set; }
        /// <summary> Subsample ratio of the training instance. </summary>
        public string Subsample { get; set; }
        /// <summary> Frequency of subsample. </summary>
        public string SubsampleFreq { get; set; }
        /// <summary> Specify the tree method. </summary>
        public string TreeMethod { get; set; }
        /// <summary> If true, center before scaling the data with StandardScalar. </summary>
        public string WithMean { get; set; }
        /// <summary> If true, scaling the data with Unit Variance with StandardScalar. </summary>
        public string WithStd { get; set; }
    }
}
