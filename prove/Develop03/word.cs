using System;

public class Word
{

    private string _word;
    private bool _isHidden;

    public Word(string word){
        word = _word;
    }

    public bool GetIsHidden(){
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden){
        _isHidden = isHidden;
    }

    public string GetWord(){
        return _word;
    }

}