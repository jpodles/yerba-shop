import { useEffect, useState } from "react";

const useFetch = (url) => {
  const [data, setData] = useState(null);
  const [isPending, setIsPending] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const abortControll = new AbortController();
    setTimeout(() => {
      fetch(url, { signal: abortControll.signal })
        .then((res) => {
          if (!res.ok) {
            throw Error("Could not fetch data");
          }
          return res.json();
        })
        .then((data) => {
          setData(data);
          setIsPending(false);
          setError(null);
        })
        .catch((err) => {
          if (err.name === "AbortError") {
            console.log("fetch aborted");
          }
          setIsPending(false);
          setError(err.message);
        });
    }, 1000);

    return () => abortControll.abort();
  }, [url]);

  return { data, isPending, error };
};

export default useFetch;
