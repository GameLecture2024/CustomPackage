using UnityEngine;
using UnityEditor;
using UnityEditor.Compilation;

[ExecuteInEditMode]
public class CompilationTimer : MonoBehaviour
{
    private double compileStartTime;
    private bool isCompiling;

    private void OnEnable()
    {
        EditorApplication.update += EditorUpdate;
        CompilationPipeline.compilationStarted += CompilationStarted;
    }

    private void OnDisable()
    {
        EditorApplication.update -= EditorUpdate;
        CompilationPipeline.compilationStarted -= CompilationStarted;
    }

    private void EditorUpdate()
    {
        if (isCompiling && !EditorApplication.isCompiling)
        {
            isCompiling = false;
            CompileFinished();
        }
    }

    private void CompilationStarted(object context)
    {
        Debug.Log("Compile Started.");
        isCompiling = true;
        compileStartTime = EditorApplication.timeSinceStartup;
    }

    private void CompileFinished()
    {
        double compileTime = EditorApplication.timeSinceStartup - compileStartTime;
        Debug.Log("Compile Finished: " + compileTime.ToString("F2") + "s");
    }
}
