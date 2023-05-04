using System;

class Scripture{

private List<Word> _words = new List<Word>();

private Reference _scriptureReference;

public Scripture(Reference scriptureReference, string scriptureText)
{
    _scriptureReference = scriptureReference;

    CreateWords(scriptureText);

    
    }
private void CreateWords(string scriptureText){
    List<string> allWords = scriptureText.Split(' ').ToList();
    foreach(string item in allWords){
        Word newWord = new Word(item);
        _words.Add(newWord);
    }
    }
public string GetScripture(){
    string scriptureText = " ";
    foreach (Word word in _words){
        if (word.GetIsHidden() == false){
            scriptureText += word.GetWord() + ' ';
        }
        else
        {
            scriptureText += new string('_', word.GetWord().Length) + " ";
        }
    }
    return ($"{_scriptureReference.GetReference()} {scriptureText}");
}

public bool HasWordsLeft(){
    bool retValue = false;

    foreach (Word word in _words){
        if(word.GetIsHidden() == false){
            retValue = true;
        }
    }

    return retValue;
}

public void RemoveWords(){
    int numWordsToRemove = new Random().Next(2,4);
    int wordsRemoved = 0;

    do
    {
        int rndIndex = new Random().Next(0, _words.Count());

        if (_words[rndIndex].GetIsHidden() == false)
        {
            _words[rndIndex].SetIsHidden(true);
            wordsRemoved++;
        }

}while (wordsRemoved != numWordsToRemove && HasWordsLeft() == true);

}


}