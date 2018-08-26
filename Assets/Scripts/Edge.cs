/**
 * Author:    Rakesh Kumar
 * Created:   23.07.2018
 * 
 **/
using System.Collections;
using System.Collections.Generic;

public class Edge
{
    public Polygon m_InnerPoly;
    public Polygon m_OuterPoly;
    public List<int> m_OuterVerts;
    public List<int> m_InnerVerts;
    public Edge(Polygon inner_poly, Polygon outer_poly)
    {
        m_InnerPoly = inner_poly;
        m_OuterPoly = outer_poly;
        m_OuterVerts = new List<int>(2);
        m_InnerVerts = new List<int>(2);

        foreach (int vertex in inner_poly.m_Vertices)
        {
            if (outer_poly.m_Vertices.Contains(vertex))
                m_InnerVerts.Add(vertex);
        }
        
        if (m_InnerVerts[0] == inner_poly.m_Vertices[0] &&
           m_InnerVerts[1] == inner_poly.m_Vertices[2])
        {
            int temp = m_InnerVerts[0];
            m_InnerVerts[0] = m_InnerVerts[1];
            m_InnerVerts[1] = temp;
        }
        m_OuterVerts = new List<int>(m_InnerVerts);
    }
}