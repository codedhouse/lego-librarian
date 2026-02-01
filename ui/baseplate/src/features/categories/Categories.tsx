import { useEffect, useState } from 'react';
import axios from 'axios';

export const Categories = () => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    // Fetch data
    axios
      .get('http://localhost:5261/api/categories')
      .then((res) => {
        setData(res.data);
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message);
        setLoading(false);
      });
  }, []);

  if (loading) return <div>Loading...</div>;
  if (error) return <div>Error: {error}</div>;

  return (
    <div>
      {data.map((category: any) => (
        <p key={category.id}>{category.name}</p>
      ))}
    </div>
  );
};
