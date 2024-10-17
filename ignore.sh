#!/bin/bash

echo "VERCEL_GIT_COMMIT_REF: $VERCEL_GIT_COMMIT_REF"
echo "VERCEL_GIT_PULL_REQUEST_ID: $VERCEL_GIT_PULL_REQUEST_ID"
echo "VERCEL_GIT_COMMIT_MESSAGE: $VERCEL_GIT_COMMIT_MESSAGE"
echo "VERCEL_GIT_REPO_SLUG: $VERCEL_GIT_REPO_SLUG"
echo "VERCEL_GIT_REPO_OWNER: $VERCEL_GIT_REPO_OWNER"

if [[ "$VERCEL_GIT_COMMIT_REF" == "main" || "$VERCEL_GIT_COMMIT_REF" == "staging"  ]] ; then
  # Proceed with the build
    echo "✅ - Build can proceed"
  exit 1;
fi

# Don't build
  echo "🛑 - Build cancelled"
  exit 0;