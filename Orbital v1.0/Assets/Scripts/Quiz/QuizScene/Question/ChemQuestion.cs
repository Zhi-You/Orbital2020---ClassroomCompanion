﻿

// storing information for each question. Just an empty class for this
// Using object orientation programming. Describing the question object for our game 
// Whatever info associated to a question will be stored in here

using UnityEngine;
using UnityEngine.UI;

[System.Serializable]               // Can be saved and store info. Allows us to edit in inspector
public class ChemQuestion
{
    public string question;
    public Sprite questionImage = null;
    public QuestionTopicChem topic;
    public int answer;
    public int numberOfOptions;

    public string option1;
    public string option2;
    public string option3;
    public string option4;

    public string explanation;      // for summary scene

}


public enum QuestionTopicChem { ElementsCompoundsAndMixtures, SeparatingTechniques, ChemicalChanges, KineticParticleTheory, Atoms1, Atoms2  }