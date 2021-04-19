using layer_0.cell;

namespace layer_0.cell
{
    public interface c_db_factory
    {
        c_db<T> general<T>() where T : m_id;
        c_db<m_sync> sync(string xid, string userid);
    }
}