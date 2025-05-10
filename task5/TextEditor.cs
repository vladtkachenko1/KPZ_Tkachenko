using System;
using System.Collections.Generic;
using System.IO;
using task5;

public class TextEditor
{
    private TextDocument document = new TextDocument();
    private List<DocumentMemento> history = new List<DocumentMemento>();

    public void AddLine(string line)
    {
        Save();
        document.AddLine(line);
    }

    public void Save()
    {
        history.Add(new DocumentMemento(document.GetContent()));
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            var lastIndex = history.Count - 1;
            var previousState = history[lastIndex];
            document.SetContent(previousState.GetSavedState());
            history.RemoveAt(lastIndex);
            Console.WriteLine("Останню зміну скасовано.");
        }
        else
        {
            Console.WriteLine("Немає змін для скасування.");
        }
    }

    public void Restore(int index)
    {
        if (index >= 0 && index < history.Count)
        {
            var state = history[index];
            document.SetContent(state.GetSavedState());
            Console.WriteLine($"Стан документа відновлено (версія {index + 1}).");
        }
        else
        {
            Console.WriteLine("Невірний індекс версії.");
        }
    }

    public void ShowSavedVersions()
    {
        Console.WriteLine("\n--- Список збережених версій ---");
        for (int i = 0; i < history.Count; i++)
        {
            Console.WriteLine($"Версія {i + 1}");
        }
        if (history.Count == 0)
            Console.WriteLine("[Немає збережених версій]");
        Console.WriteLine("--------------------------------\n");
    }

    public void SaveToFile()
    {
        try
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "document.txt");
            File.WriteAllLines(filePath, document.GetContent());
            Console.WriteLine($"Документ успішно збережено у файл: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при збереженні: {ex.Message}");
        }
    }


    public void Show()
    {
        document.Show();
    }
}