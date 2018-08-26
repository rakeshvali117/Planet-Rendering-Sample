/**
 * Author:    Rakesh Kumar
 * Created:   23.07.2018
 * 
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeSet : HashSet<Edge>
{
    public void Split(List<int> oldVertices, List<int> newVertices)
    {
        foreach (Edge edge in this)
        {
            for (int i = 0; i < 2; i++)
            {
                edge.m_InnerVerts[i] = newVertices[oldVertices.IndexOf(
                                       edge.m_OuterVerts[i])];
            }
        }
    }

    public List<int> GetUniqueVertices()
    {
        List<int> vertices = new List<int>();
        foreach (Edge edge in this)
        {
            foreach (int vert in edge.m_OuterVerts)
            {
                if (!vertices.Contains(vert))
                    vertices.Add(vert);
            }
        }
        return vertices;
    }
}