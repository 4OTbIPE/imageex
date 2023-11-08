namespace ImageEx;
/// <summary>
/// Provides attached dependency properties for the <see cref="DependencyObject"/> type.
/// </summary>
public static class DependencyObjectExtensions
{
    /// <summary>
    /// Find all ascendant elements of the specified element. This method can be chained with
    /// LINQ calls to add additional filters or projections on top of the returned results.
    /// <para>
    /// This method is meant to provide extra flexibility in specific scenarios and it should not
    /// be used when only the first item is being looked for. In those cases, use one of the
    /// available <see cref="FindAscendant{T}(DependencyObject)"/> overloads instead, which will
    /// offer a more compact syntax as well as better performance in those cases.
    /// </para>
    /// </summary>
    /// <param name="element">The root element.</param>
    /// <returns>All the descendant <see cref="DependencyObject"/> instance from <paramref name="element"/>.</returns>
    public static IEnumerable<DependencyObject> FindAscendants(this DependencyObject element)
    {
        while (true)
        {
            DependencyObject parent = VisualTreeHelper.GetParent(element);

            if (parent is null)
            {
                yield break;
            }

            yield return parent;

            element = parent;
        }
    }
}
